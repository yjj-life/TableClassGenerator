namespace TableClassGenerator.Views
{
	partial class ConnectDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblServerName = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.lblAuthencation = new System.Windows.Forms.Label();
			this.cmbAuthencate = new System.Windows.Forms.ComboBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.lblLogin = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.chkRemember = new System.Windows.Forms.CheckBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblServerName
			// 
			this.lblServerName.AutoSize = true;
			this.lblServerName.Location = new System.Drawing.Point(56, 65);
			this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblServerName.Name = "lblServerName";
			this.lblServerName.Size = new System.Drawing.Size(95, 17);
			this.lblServerName.TabIndex = 0;
			this.lblServerName.Text = "Server name:";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(171, 61);
			this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(347, 24);
			this.txtServerName.TabIndex = 1;
			this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
			// 
			// lblAuthencation
			// 
			this.lblAuthencation.AutoSize = true;
			this.lblAuthencation.Location = new System.Drawing.Point(52, 103);
			this.lblAuthencation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAuthencation.Name = "lblAuthencation";
			this.lblAuthencation.Size = new System.Drawing.Size(99, 17);
			this.lblAuthencation.TabIndex = 2;
			this.lblAuthencation.Text = "Authencation:";
			// 
			// cmbAuthencate
			// 
			this.cmbAuthencate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAuthencate.FormattingEnabled = true;
			this.cmbAuthencate.Items.AddRange(new object[] {
            "Windows Authencate",
            "SQL Server Authencate"});
			this.cmbAuthencate.Location = new System.Drawing.Point(171, 99);
			this.cmbAuthencate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbAuthencate.Name = "cmbAuthencate";
			this.cmbAuthencate.Size = new System.Drawing.Size(347, 25);
			this.cmbAuthencate.TabIndex = 3;
			this.cmbAuthencate.SelectedIndexChanged += new System.EventHandler(this.cmbAuthencate_SelectedIndexChanged);
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(185, 136);
			this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(332, 24);
			this.txtLogin.TabIndex = 5;
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(105, 140);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(48, 17);
			this.lblLogin.TabIndex = 4;
			this.lblLogin.Text = "Login:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(185, 171);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(332, 24);
			this.txtPassword.TabIndex = 7;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(76, 176);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(74, 17);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Password:";
			// 
			// chkRemember
			// 
			this.chkRemember.AutoSize = true;
			this.chkRemember.Location = new System.Drawing.Point(185, 207);
			this.chkRemember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkRemember.Name = "chkRemember";
			this.chkRemember.Size = new System.Drawing.Size(161, 21);
			this.chkRemember.TabIndex = 8;
			this.chkRemember.Text = "Remember password";
			this.chkRemember.UseVisualStyleBackColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(359, 295);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(100, 33);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(467, 295);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 33);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(19, 271);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(548, 1);
			this.label5.TabIndex = 11;
			// 
			// ConnectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(592, 357);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.chkRemember);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.cmbAuthencate);
			this.Controls.Add(this.lblAuthencation);
			this.Controls.Add(this.txtServerName);
			this.Controls.Add(this.lblServerName);
			this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(608, 395);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(608, 395);
			this.Name = "ConnectDialog";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Conect to Server";
			this.Load += new System.EventHandler(this.ConnectDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblServerName;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label lblAuthencation;
		private System.Windows.Forms.ComboBox cmbAuthencate;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.CheckBox chkRemember;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label5;
	}
}