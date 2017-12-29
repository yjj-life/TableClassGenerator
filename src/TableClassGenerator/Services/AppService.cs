using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TableClassGenerator.Models;

namespace TableClassGenerator.Services
{
	public class AppService
	{
		private Authentication _authentication;
		private MainFormModel _mainModel = new MainFormModel();
		public ErrorInfo ErrorInfo { get; set; } = new ErrorInfo();
		
		public bool Connect(Authentication auth)
		{
			string constr = BuildConnectionString(auth);

			bool bCanConect = true;
			using (SqlConnection con = new SqlConnection(constr))
			{
				try
				{
					con.Open();
				}
				catch(SqlException ex)
				{
					this.ErrorInfo.Code = ex.ErrorCode;
					this.ErrorInfo.Message = ex.Message;
					bCanConect = false;
				}
			}

			if (bCanConect)
			{
				this._authentication = auth;
			}

			return bCanConect;
		}

		public void DisConnect()
		{
			this._authentication = null;
		}

		public bool IsConnected()
		{
			return this._authentication != null;
		}

		public string GetLoginUser()
		{
			if (this._authentication.AuthType == AuthType.Integration)
			{
				return string.Format(@"{0}\{1}", Environment.UserDomainName, Environment.UserName);
			}
			else
			{
				return this._authentication.Username;
			}
		}

		public MainFormModel FetchSQLServerInfo()
		{
			if (IsConnected() == false)
			{
				return this._mainModel;
			}

			string constr = BuildConnectionString(this._authentication);
			using (SqlConnection con = new SqlConnection(constr))
			{
				try
				{
					con.Open();

					// Create the command and open the connection
					var command = con.CreateCommand();
					command.CommandTimeout = 15;
					command.CommandType = CommandType.Text;

					var result = ReadServerInfo(command);

					this._mainModel.ServerName = result.Item1;
					this._mainModel.SQLServerVersion = result.Item2;
					this._mainModel.Databases = ReadDatabases(command);
				}
				catch (SqlException ex)
				{
					this.ErrorInfo.Code = ex.ErrorCode;
					this.ErrorInfo.Message = ex.Message;
				}
			}

			return this._mainModel;
		}

		public MainFormModel FetchDatabaseInfo(string database)
		{
			this._mainModel.Tables = null;
			this._mainModel.TablesSchema = new Dictionary<string, List<TableSchema>>();

			if (IsConnected() == false)
			{
				return this._mainModel;
			}

			string constr = BuildConnectionString(_authentication, database);
			using (SqlConnection con = new SqlConnection(constr))
			{
				try
				{
					con.Open();

					// Create the command and open the connection
					var command = con.CreateCommand();
					command.CommandTimeout = 15;
					command.CommandType = CommandType.Text;

					this._mainModel.Tables = ReadTables(command);
				}
				catch (SqlException ex)
				{
					this.ErrorInfo.Code = ex.ErrorCode;
					this.ErrorInfo.Message = ex.Message;
				}
			}

			return this._mainModel;
		}

		public MainFormModel FetchTableSchema(string database, string table)
		{
			if (IsConnected() == false)
			{
				return this._mainModel;
			}

			if (this._mainModel.TablesSchema.TryGetValue(table, out List<TableSchema> listSchema))
			{
				return this._mainModel;
			}

			string constr = BuildConnectionString(_authentication, database);
			using (SqlConnection con = new SqlConnection(constr))
			{
				try
				{
					con.Open();

					// Create the command and open the connection
					var command = con.CreateCommand();
					command.CommandTimeout = 15;
					command.CommandType = CommandType.Text;
					var schema = ReadTableSchema(command, table, ReadPrimaryColumn(command, table));
					this._mainModel.TablesSchema.Add(table, schema);

				}
				catch (SqlException ex)
				{
					this.ErrorInfo.Code = ex.ErrorCode;
					this.ErrorInfo.Message = ex.Message;
				}
			}

			return this._mainModel;
		}

		public string MakeClassText(string table, string @namespace)
		{
			if (!this._mainModel.TablesSchema.TryGetValue(table, out List<TableSchema> schemas))
			{
				return "";
			}

			StringBuilder sb = new StringBuilder();

			sb.AppendLine("using Provider.Schema.Attributes;");
			sb.AppendLine("");
			sb.AppendLine(string.Format("namespace {0}", @namespace));
			sb.AppendLine("{");
			sb.AppendLine(string.Format("\tpublic class {0}", table));
			sb.AppendLine("\t{");
			schemas.ForEach(schema =>
			{
				if (schema.Primary)
				{
					sb.AppendLine("\t\t[Column(Type = ColumnType.PrimaryKey)]");
				}
				sb.AppendLine(string.Format("\t\tpublic {0} {1} {2} get; set; {3}", ConvertSqlType(schema.DataType), schema.Column, "{", "}"));
			});
			sb.AppendLine("\t}");
			sb.Append("}");

			return sb.ToString();
		}

		private string ConvertSqlType(string type)
		{
			switch (type)
			{
				case "char":
					type = "string";
					break;
				case "smallint":
					type = "short";
					break;
				case "int":
					break;
			}

			return type;
		}

		private Tuple<string, string> ReadServerInfo(SqlCommand command)
		{
			string servername = "";
			string version = "";
			command.CommandText = "SELECT SERVERPROPERTY('servername'), SERVERPROPERTY('ProductVersion')";
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					servername = reader[0].ToString();
					version = reader[1].ToString();
				}
			}

			return new Tuple<string, string>(servername, version);
		}

		private List<string> ReadDatabases(SqlCommand command)
		{
			List<string> databases = new List<string>();

			command.CommandText = "select name from sys.databases where owner_sid <> 0x01 order by name";
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					databases.Add(reader[0].ToString());
				}
			}

			return databases;
		}

		private List<string> ReadTables(SqlCommand command)
		{
			List<string> tables = new List<string>();

			command.CommandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_CATALOG, TABLE_SCHEMA, TABLE_NAME";
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					tables.Add(reader[0].ToString());
				}
			}

			return tables;
		}

		private List<TableSchema> ReadTableSchema(SqlCommand command, string table, List<string> primaryColumns)
		{
			List<TableSchema> columns = new List<TableSchema>();

			command.CommandText = string.Format("select c.name as column_name, tp.name as data_type, c.max_length from sys.tables t join sys.columns c on t.object_id=c.object_id join sys.types tp on c.system_type_id=tp.system_type_id where t.name='{0}' order by c.column_id", table);
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					TableSchema schema = new TableSchema
					{
						Column = reader[0].ToString(),
						DataType = reader[1].ToString(),
						Length = Convert.ToInt32(reader[2])
					};

					schema.Primary = primaryColumns.Any(x => x == schema.Column);

					columns.Add(schema);
				}
			}

			return columns;
		}

		private List<string> ReadPrimaryColumn(SqlCommand command, string table)
		{
			List<string> primaryColumns = new List<string>();

			command.CommandText = string.Format("SELECT column_name FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS KU ON TC.CONSTRAINT_TYPE = 'PRIMARY KEY' AND TC.CONSTRAINT_NAME = KU.CONSTRAINT_NAME Where KU.table_name='{0}' ORDER BY KU.TABLE_NAME, KU.ORDINAL_POSITION", table);
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					primaryColumns.Add(reader[0].ToString());
				}
			}

			return primaryColumns;
		}

		private static string BuildConnectionString(Authentication auth, string database = "master")
		{
			string constr;
			if (auth.AuthType == AuthType.Integration)
			{
				constr = string.Format(@"Integrated Security=true;Initial Catalog={0};Data Source={1}", database, auth.ServerName);
			}
			else
			{
				constr = BuildConnectionString(auth.ServerName, database, auth.Username, auth.Password);
			}

			return constr;
		}
		private static string BuildConnectionString(string server, string database, string username, string password)
		{
			// Create a connection string builder
			SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder
			{
				DataSource = server
			};

			// Define connection string attributes using three techniques
			csb.Add("Initial Catalog", database);
			csb.Add("User Id", username);
			csb.Add("Password", password);
			//csb["Integrated Security"] = true;

			return csb.ConnectionString;
		}

	}
}
