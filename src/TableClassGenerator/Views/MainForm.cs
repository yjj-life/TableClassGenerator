using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TableClassGenerator.Models;
using TableClassGenerator.Services;

namespace TableClassGenerator.Views
{
	public partial class MainForm : Form
	{
		private AppService _appService;
		private MainFormModel _mainModel;

		public MainForm(AppService appService)
		{
			InitializeComponent();
			this._appService = appService;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			ConnectToServer();
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			this._appService.DisConnect();
			RefreshControlState();
		}

		private void btnFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog browserDialog = new FolderBrowserDialog();
			browserDialog.Description = "Special the output folder.";
			browserDialog.SelectedPath = this.txtFolder.Text;
			if (browserDialog.ShowDialog() == DialogResult.OK)
			{
				this.txtFolder.Text = browserDialog.SelectedPath;
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{

		}

		private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
		{
			FetchDatabaseInfo();
			UpdateTableList();
		}

		private void clbTableList_SelectedIndexChanged(object sender, EventArgs e)
		{
			FetchTableSchema();
			UpdateTableSchemaGridView();
			UpdateClassPreview();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshControlState();
		}

		private void ConnectToServer()
		{
			Form dlgConnect = new ConnectDialog(this._appService);
			dlgConnect.ShowDialog();

			RefreshControlState();

			FetchSQLServerInfo();
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			ConnectToServer();
		}

		private void RefreshControlState()
		{
			if (this._appService.IsConnected() == false)
			{
				this.btnConnect.Enabled = true;
				this.btnConnect.Image = Properties.Resources.connect;

				this.btnDisconnect.Enabled = false;
				this.btnDisconnect.Image = Properties.Resources.disconnect_g;

				this.btnCheckAll.Enabled = false;
				this.btnCheckAll.Image = Properties.Resources.check_g;

				this.cmbDatabase.Items.Clear();
				this.cmbDatabase.Enabled = false;
				this.clbTableList.Items.Clear();
				this.clbTableList.Focus();

				this.txtFolder.Text = "";
				this.lblTitle.Text = "";
				this.gridSchema.Columns.Clear();
				this.txtClassPreview.Text = "";
			}
			else
			{
				this.btnConnect.Enabled = false;
				this.btnConnect.Image = Properties.Resources.connect_g;

				this.btnDisconnect.Enabled = true;
				this.btnDisconnect.Image = Properties.Resources.disconnect;

				this.btnCheckAll.Enabled = true;
				this.btnCheckAll.Image = Properties.Resources.check;

				this.cmbDatabase.Enabled = true;

				this.gridSchema.Columns.Add(this.colColumn);
				this.gridSchema.Columns.Add(this.colPrimary);
				this.gridSchema.Columns.Add(this.colType);
				this.gridSchema.Columns.Add(this.colLength);
			}
		}

		private void FetchSQLServerInfo()
		{
			if (this._appService.IsConnected() == false)
			{
				return;
			}

			this._mainModel = this._appService.FetchSQLServerInfo();

			this.lblTitle.Text = string.Format("{0} (SQL Server {1} - {2})", this._mainModel.ServerName, this._mainModel.SQLServerVersion, this._appService.GetLoginUser());

			this.cmbDatabase.Items.AddRange(this._mainModel.Databases.ToArray());
			this.cmbDatabase.SelectedIndex = 0;
		}

		private void FetchDatabaseInfo()
		{
			if (this._appService.IsConnected() == false)
			{
				return;
			}

			this._mainModel = this._appService.FetchDatabaseInfo(GetSelectedDatabase());
		}

		private void UpdateTableList()
		{
			this.clbTableList.Items.Clear();
			this.clbTableList.Items.AddRange(this._mainModel.Tables.ToArray());
		}

		private void FetchTableSchema()
		{
			if (this._appService.IsConnected() == false)
			{
				return;
			}

			this._mainModel = this._appService.FetchTableSchema(GetSelectedDatabase(), GetSelectedTable());
		}

		private void UpdateTableSchemaGridView()
		{
			this.gridSchema.Rows.Clear();
			if (!this._mainModel.TablesSchema.TryGetValue(GetSelectedTable(), out List<TableSchema> schemas))
			{
				return;
			}

			schemas.ForEach(schema =>
			{
				int index = this.gridSchema.Rows.Add();
				this.gridSchema.Rows[index].Cells[0].Value = schema.Column;
				this.gridSchema.Rows[index].Cells[1].Value = schema.Primary;
				this.gridSchema.Rows[index].Cells[2].Value = schema.DataType;
				this.gridSchema.Rows[index].Cells[3].Value = schema.Length;
			});
		}

		private void UpdateClassPreview()
		{
			this.txtClassPreview.Text = this._appService.MakeClassText(GetSelectedTable(), this.txtNamespace.Text);
		}

		private string GetSelectedDatabase()
		{
			return this._mainModel.Databases[this.cmbDatabase.SelectedIndex];
		}

		private string GetSelectedTable()
		{
			return this._mainModel.Tables[this.clbTableList.SelectedIndex];
		}

		private void btnCheckAll_Click(object sender, EventArgs e)
		{
			for (int i = 0, count = this.clbTableList.Items.Count; i < count; i++)
			{
				this.clbTableList.SetItemChecked(i, true);
			}
		}

		private void btnUnCheck_Click(object sender, EventArgs e)
		{
			for (int i = 0, count = this.clbTableList.Items.Count; i < count; i++)
			{
				this.clbTableList.SetItemChecked(i, false);
			}
		}

		private void gridSchema_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			var grid = sender as DataGridView;
			var rowIdx = (e.RowIndex + 1).ToString();

			var centerFormat = new StringFormat()
			{
				// right alignment might actually make more sense for numbers  
				Alignment = StringAlignment.Center,
				LineAlignment = StringAlignment.Center
			};

			var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
			e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
		}

		private void txtNamespace_TextChanged(object sender, EventArgs e)
		{
			UpdateClassPreview();
		}
	}
}
