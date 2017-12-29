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
	public partial class ConnectDialog : Form
	{
		private AppService _appService;

		public ConnectDialog(AppService appService)
		{
			InitializeComponent();
			this._appService = appService;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			if (CheckLoginData() == false)
			{				
				MessageBox.Show(string.Format("Cann't connect to {0}.\nLogin has not be setup.", this.txtServerName.Text), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (this._appService.Connect(CreateAuthentication()) == false)
			{
				MessageBox.Show(string.Format("Cann't connect to {0}.\n '{1}'", this.txtServerName.Text, this._appService.ErrorInfo.Message), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ConnectDialog_Load(object sender, EventArgs e)
		{
			this.txtServerName.Text = Environment.MachineName;
			this.cmbAuthencate.SelectedIndex = 0;
			SetConectBtnState();
		}

		private void cmbAuthencate_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (GetAuthenticationType() == AuthType.Integration)
			{
				SetWindowsLogin();
			}
			else
			{
				SetSQLServerLogin();
			}
		}

		private void SetWindowsLogin()
		{
			this.txtLogin.Enabled = false;
			this.txtLogin.Text = string.Format(@"{0}\{1}", Environment.UserDomainName, Environment.UserName);

			this.txtPassword.Enabled = false;
			this.txtPassword.Text = "";

			this.chkRemember.Enabled = false;
			this.chkRemember.Checked = false;
		}

		private void SetSQLServerLogin()
		{
			this.txtLogin.Enabled = true;
			this.txtLogin.Text = "sa";

			this.txtPassword.Enabled = true;
			this.chkRemember.Enabled = true;
		}

		private bool CheckLoginData()
		{
			bool bCheckResult = true;

			if (GetAuthenticationType() == AuthType.SQLServer)
			{
				if (this.txtLogin.Text.Length == 0)
				{
					bCheckResult = false;
				}
			}

			return bCheckResult;
		}

		private void txtServerName_TextChanged(object sender, EventArgs e)
		{
			SetConectBtnState();
		}

		private void SetConectBtnState()
		{
			this.btnConnect.Enabled = this.txtServerName.Text.Length > 0;
		}

		private AuthType GetAuthenticationType()
		{
			return this.cmbAuthencate.SelectedIndex == 0 ? AuthType.Integration : AuthType.SQLServer;
		}

		private Authentication CreateAuthentication()
		{
			return new Authentication
			{
				ServerName = this.txtServerName.Text,
				Username = this.txtLogin.Text,
				Password = this.txtPassword.Text,
				AuthType = GetAuthenticationType()
			};
		}
	}
}
