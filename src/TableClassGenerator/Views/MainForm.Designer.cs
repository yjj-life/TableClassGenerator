namespace TableClassGenerator.Views
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.spcMainForm = new System.Windows.Forms.SplitContainer();
			this.spcDatabase = new System.Windows.Forms.SplitContainer();
			this.cmbDatabase = new System.Windows.Forms.ComboBox();
			this.clbTableList = new System.Windows.Forms.CheckedListBox();
			this.tsConnection = new System.Windows.Forms.ToolStrip();
			this.lblConnect = new System.Windows.Forms.ToolStripLabel();
			this.btnConnect = new System.Windows.Forms.ToolStripButton();
			this.btnDisconnect = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCheckAll = new System.Windows.Forms.ToolStripButton();
			this.btnUnCheck = new System.Windows.Forms.ToolStripButton();
			this.spcGeneration = new System.Windows.Forms.SplitContainer();
			this.gridSchema = new System.Windows.Forms.DataGridView();
			this.colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrimary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtClassPreview = new System.Windows.Forms.TextBox();
			this.lblPreview = new System.Windows.Forms.Label();
			this.tsGeneration = new System.Windows.Forms.ToolStrip();
			this.lblNamespace = new System.Windows.Forms.ToolStripLabel();
			this.txtNamespace = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.lblFolder = new System.Windows.Forms.ToolStripLabel();
			this.txtFolder = new System.Windows.Forms.ToolStripTextBox();
			this.btnFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnGenerate = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.spcMainForm)).BeginInit();
			this.spcMainForm.Panel1.SuspendLayout();
			this.spcMainForm.Panel2.SuspendLayout();
			this.spcMainForm.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcDatabase)).BeginInit();
			this.spcDatabase.Panel1.SuspendLayout();
			this.spcDatabase.Panel2.SuspendLayout();
			this.spcDatabase.SuspendLayout();
			this.tsConnection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcGeneration)).BeginInit();
			this.spcGeneration.Panel1.SuspendLayout();
			this.spcGeneration.Panel2.SuspendLayout();
			this.spcGeneration.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSchema)).BeginInit();
			this.tsGeneration.SuspendLayout();
			this.SuspendLayout();
			// 
			// spcMainForm
			// 
			this.spcMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcMainForm.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcMainForm.Location = new System.Drawing.Point(0, 0);
			this.spcMainForm.Margin = new System.Windows.Forms.Padding(0);
			this.spcMainForm.Name = "spcMainForm";
			// 
			// spcMainForm.Panel1
			// 
			this.spcMainForm.Panel1.Controls.Add(this.spcDatabase);
			this.spcMainForm.Panel1.Controls.Add(this.tsConnection);
			// 
			// spcMainForm.Panel2
			// 
			this.spcMainForm.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.spcMainForm.Panel2.Controls.Add(this.spcGeneration);
			this.spcMainForm.Panel2.Controls.Add(this.tsGeneration);
			this.spcMainForm.Size = new System.Drawing.Size(1046, 796);
			this.spcMainForm.SplitterDistance = 244;
			this.spcMainForm.SplitterIncrement = 4;
			this.spcMainForm.SplitterWidth = 6;
			this.spcMainForm.TabIndex = 0;
			this.spcMainForm.TabStop = false;
			// 
			// spcDatabase
			// 
			this.spcDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcDatabase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcDatabase.IsSplitterFixed = true;
			this.spcDatabase.Location = new System.Drawing.Point(0, 29);
			this.spcDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.spcDatabase.Name = "spcDatabase";
			this.spcDatabase.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spcDatabase.Panel1
			// 
			this.spcDatabase.Panel1.Controls.Add(this.cmbDatabase);
			this.spcDatabase.Panel1MinSize = 10;
			// 
			// spcDatabase.Panel2
			// 
			this.spcDatabase.Panel2.Controls.Add(this.clbTableList);
			this.spcDatabase.Size = new System.Drawing.Size(244, 767);
			this.spcDatabase.SplitterDistance = 29;
			this.spcDatabase.SplitterWidth = 1;
			this.spcDatabase.TabIndex = 1;
			// 
			// cmbDatabase
			// 
			this.cmbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDatabase.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cmbDatabase.FormattingEnabled = true;
			this.cmbDatabase.ItemHeight = 17;
			this.cmbDatabase.Items.AddRange(new object[] {
            "amano_cx",
            "comlimitdb",
            "commktmngmntdb",
            "commngmntdb",
            "CXK01042"});
			this.cmbDatabase.Location = new System.Drawing.Point(3, 3);
			this.cmbDatabase.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.cmbDatabase.MaxDropDownItems = 10;
			this.cmbDatabase.Name = "cmbDatabase";
			this.cmbDatabase.Size = new System.Drawing.Size(234, 25);
			this.cmbDatabase.TabIndex = 1;
			this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
			// 
			// clbTableList
			// 
			this.clbTableList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clbTableList.FormattingEnabled = true;
			this.clbTableList.IntegralHeight = false;
			this.clbTableList.Location = new System.Drawing.Point(6, 6);
			this.clbTableList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.clbTableList.Name = "clbTableList";
			this.clbTableList.Size = new System.Drawing.Size(234, 726);
			this.clbTableList.TabIndex = 2;
			this.clbTableList.SelectedIndexChanged += new System.EventHandler(this.clbTableList_SelectedIndexChanged);
			// 
			// tsConnection
			// 
			this.tsConnection.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnect,
            this.btnConnect,
            this.btnDisconnect,
            this.toolStripSeparator2,
            this.btnCheckAll,
            this.btnUnCheck});
			this.tsConnection.Location = new System.Drawing.Point(0, 0);
			this.tsConnection.Name = "tsConnection";
			this.tsConnection.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.tsConnection.Size = new System.Drawing.Size(244, 29);
			this.tsConnection.TabIndex = 0;
			this.tsConnection.Text = "toolStrip1";
			// 
			// lblConnect
			// 
			this.lblConnect.Name = "lblConnect";
			this.lblConnect.Size = new System.Drawing.Size(55, 20);
			this.lblConnect.Text = "Connect";
			// 
			// btnConnect
			// 
			this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnConnect.Image = global::TableClassGenerator.Properties.Resources.connect;
			this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(23, 20);
			this.btnConnect.Text = "toolStripButton1";
			this.btnConnect.ToolTipText = "Connect to SQL Server";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDisconnect.Image = global::TableClassGenerator.Properties.Resources.disconnect;
			this.btnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(23, 20);
			this.btnDisconnect.Text = "toolStripButton2";
			this.btnDisconnect.ToolTipText = "Disconnect";
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
			// 
			// btnCheckAll
			// 
			this.btnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCheckAll.Image = global::TableClassGenerator.Properties.Resources.check;
			this.btnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCheckAll.Name = "btnCheckAll";
			this.btnCheckAll.Size = new System.Drawing.Size(23, 20);
			this.btnCheckAll.ToolTipText = "Select all tables";
			this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
			// 
			// btnUnCheck
			// 
			this.btnUnCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnUnCheck.Image = global::TableClassGenerator.Properties.Resources.uncheck;
			this.btnUnCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUnCheck.Name = "btnUnCheck";
			this.btnUnCheck.Size = new System.Drawing.Size(23, 20);
			this.btnUnCheck.Text = "toolStripButton1";
			this.btnUnCheck.ToolTipText = "Unselect tables";
			this.btnUnCheck.Click += new System.EventHandler(this.btnUnCheck_Click);
			// 
			// spcGeneration
			// 
			this.spcGeneration.BackColor = System.Drawing.SystemColors.ControlDark;
			this.spcGeneration.CausesValidation = false;
			this.spcGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcGeneration.Location = new System.Drawing.Point(0, 31);
			this.spcGeneration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.spcGeneration.Name = "spcGeneration";
			this.spcGeneration.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spcGeneration.Panel1
			// 
			this.spcGeneration.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.spcGeneration.Panel1.Controls.Add(this.gridSchema);
			this.spcGeneration.Panel1.Controls.Add(this.lblTitle);
			// 
			// spcGeneration.Panel2
			// 
			this.spcGeneration.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.spcGeneration.Panel2.Controls.Add(this.txtClassPreview);
			this.spcGeneration.Panel2.Controls.Add(this.lblPreview);
			this.spcGeneration.Size = new System.Drawing.Size(796, 765);
			this.spcGeneration.SplitterDistance = 466;
			this.spcGeneration.SplitterWidth = 5;
			this.spcGeneration.TabIndex = 1;
			this.spcGeneration.TabStop = false;
			// 
			// gridSchema
			// 
			this.gridSchema.AllowUserToAddRows = false;
			this.gridSchema.AllowUserToDeleteRows = false;
			this.gridSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridSchema.BackgroundColor = System.Drawing.SystemColors.Window;
			this.gridSchema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridSchema.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridSchema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColumn,
            this.colPrimary,
            this.colType,
            this.colLength});
			this.gridSchema.Location = new System.Drawing.Point(1, 39);
			this.gridSchema.Name = "gridSchema";
			this.gridSchema.ReadOnly = true;
			this.gridSchema.RowTemplate.Height = 21;
			this.gridSchema.ShowEditingIcon = false;
			this.gridSchema.Size = new System.Drawing.Size(790, 424);
			this.gridSchema.TabIndex = 1;
			this.gridSchema.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridSchema_RowPostPaint);
			// 
			// colColumn
			// 
			this.colColumn.HeaderText = "Column";
			this.colColumn.Name = "colColumn";
			this.colColumn.ReadOnly = true;
			this.colColumn.Width = 150;
			// 
			// colPrimary
			// 
			this.colPrimary.HeaderText = "Primary";
			this.colPrimary.Name = "colPrimary";
			this.colPrimary.ReadOnly = true;
			this.colPrimary.Width = 80;
			// 
			// colType
			// 
			this.colType.HeaderText = "Type";
			this.colType.Name = "colType";
			this.colType.ReadOnly = true;
			// 
			// colLength
			// 
			this.colLength.HeaderText = "Length";
			this.colLength.Name = "colLength";
			this.colLength.ReadOnly = true;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.SystemColors.Info;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Size = new System.Drawing.Size(796, 33);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "server name";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtClassPreview
			// 
			this.txtClassPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtClassPreview.BackColor = System.Drawing.SystemColors.Control;
			this.txtClassPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtClassPreview.Location = new System.Drawing.Point(0, 38);
			this.txtClassPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtClassPreview.Multiline = true;
			this.txtClassPreview.Name = "txtClassPreview";
			this.txtClassPreview.ReadOnly = true;
			this.txtClassPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtClassPreview.Size = new System.Drawing.Size(791, 246);
			this.txtClassPreview.TabIndex = 1;
			// 
			// lblPreview
			// 
			this.lblPreview.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblPreview.Location = new System.Drawing.Point(0, 0);
			this.lblPreview.Name = "lblPreview";
			this.lblPreview.Size = new System.Drawing.Size(796, 34);
			this.lblPreview.TabIndex = 0;
			this.lblPreview.Text = "Preview";
			this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tsGeneration
			// 
			this.tsGeneration.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsGeneration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNamespace,
            this.txtNamespace,
            this.toolStripSeparator3,
            this.lblFolder,
            this.txtFolder,
            this.btnFolder,
            this.toolStripSeparator1,
            this.btnGenerate});
			this.tsGeneration.Location = new System.Drawing.Point(0, 0);
			this.tsGeneration.Name = "tsGeneration";
			this.tsGeneration.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
			this.tsGeneration.Size = new System.Drawing.Size(796, 31);
			this.tsGeneration.TabIndex = 0;
			this.tsGeneration.Text = "toolStrip2";
			// 
			// lblNamespace
			// 
			this.lblNamespace.Name = "lblNamespace";
			this.lblNamespace.Size = new System.Drawing.Size(76, 22);
			this.lblNamespace.Text = "Namespace";
			// 
			// txtNamespace
			// 
			this.txtNamespace.Name = "txtNamespace";
			this.txtNamespace.Size = new System.Drawing.Size(200, 25);
			this.txtNamespace.Text = "Product.Data";
			this.txtNamespace.TextChanged += new System.EventHandler(this.txtNamespace_TextChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// lblFolder
			// 
			this.lblFolder.Name = "lblFolder";
			this.lblFolder.Size = new System.Drawing.Size(48, 22);
			this.lblFolder.Text = "Output";
			// 
			// txtFolder
			// 
			this.txtFolder.AutoSize = false;
			this.txtFolder.BackColor = System.Drawing.SystemColors.Window;
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.Size = new System.Drawing.Size(300, 25);
			// 
			// btnFolder
			// 
			this.btnFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnFolder.Image = global::TableClassGenerator.Properties.Resources.folder;
			this.btnFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(23, 22);
			this.btnFolder.Text = "toolStripButton3";
			this.btnFolder.ToolTipText = "Setup output folder";
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnGenerate
			// 
			this.btnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnGenerate.Image = global::TableClassGenerator.Properties.Resources.Save;
			this.btnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(23, 22);
			this.btnGenerate.Text = "toolStripButton4";
			this.btnGenerate.ToolTipText = "Generate class files";
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 796);
			this.Controls.Add(this.spcMainForm);
			this.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tabel Class Generator";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.spcMainForm.Panel1.ResumeLayout(false);
			this.spcMainForm.Panel1.PerformLayout();
			this.spcMainForm.Panel2.ResumeLayout(false);
			this.spcMainForm.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcMainForm)).EndInit();
			this.spcMainForm.ResumeLayout(false);
			this.spcDatabase.Panel1.ResumeLayout(false);
			this.spcDatabase.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spcDatabase)).EndInit();
			this.spcDatabase.ResumeLayout(false);
			this.tsConnection.ResumeLayout(false);
			this.tsConnection.PerformLayout();
			this.spcGeneration.Panel1.ResumeLayout(false);
			this.spcGeneration.Panel2.ResumeLayout(false);
			this.spcGeneration.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.spcGeneration)).EndInit();
			this.spcGeneration.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSchema)).EndInit();
			this.tsGeneration.ResumeLayout(false);
			this.tsGeneration.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer spcMainForm;
		private System.Windows.Forms.ToolStrip tsConnection;
		private System.Windows.Forms.ToolStripLabel lblConnect;
		private System.Windows.Forms.ToolStripButton btnConnect;
		private System.Windows.Forms.ToolStripButton btnDisconnect;
		private System.Windows.Forms.ToolStrip tsGeneration;
		private System.Windows.Forms.ToolStripLabel lblFolder;
		private System.Windows.Forms.ToolStripTextBox txtFolder;
		private System.Windows.Forms.ToolStripButton btnFolder;
		private System.Windows.Forms.ToolStripButton btnGenerate;
		private System.Windows.Forms.CheckedListBox clbTableList;
		private System.Windows.Forms.SplitContainer spcGeneration;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtClassPreview;
		private System.Windows.Forms.Label lblPreview;
		private System.Windows.Forms.ComboBox cmbDatabase;
		private System.Windows.Forms.SplitContainer spcDatabase;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnCheckAll;
		private System.Windows.Forms.ToolStripButton btnUnCheck;
		private System.Windows.Forms.DataGridView gridSchema;
		private System.Windows.Forms.DataGridViewTextBoxColumn colColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colPrimary;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLength;
		private System.Windows.Forms.ToolStripLabel lblNamespace;
		private System.Windows.Forms.ToolStripTextBox txtNamespace;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}

