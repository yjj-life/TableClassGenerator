using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableClassGenerator.Models
{
	public class MainFormModel
	{
		public string OutputFolder { get; set; }

		public string ServerName { get; set; }
		public string SQLServerVersion { get; set; }
		public string Username { get; set; }

		public List<string> Databases { get; set; }
		public List<string> Tables { get; set; }

		public Dictionary<string, List<TableSchema>> TablesSchema { get; set; } = new Dictionary<string, List<TableSchema>>();
	}
}
