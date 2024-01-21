namespace SQLServerScriptExecute
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txbx_dataSource = new TextBox();
			lbl_serverName = new Label();
			lbl_user = new Label();
			txbx_userame = new TextBox();
			label1 = new Label();
			txbx_password = new TextBox();
			btn_OpenFile = new Button();
			folderBrowserDialog = new FolderBrowserDialog();
			lsbx_fileFormat = new ListBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			lsbx_allFiles = new ListBox();
			btn_execute = new Button();
			label5 = new Label();
			panel1 = new Panel();
			label6 = new Label();
			lsbx_serverNames = new ListBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			panel3 = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			panel4 = new Panel();
			panel2 = new Panel();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// txbx_dataSource
			// 
			txbx_dataSource.AccessibleRole = AccessibleRole.TitleBar;
			txbx_dataSource.Location = new Point(90, 110);
			txbx_dataSource.Name = "txbx_dataSource";
			txbx_dataSource.Size = new Size(287, 23);
			txbx_dataSource.TabIndex = 0;
			// 
			// lbl_serverName
			// 
			lbl_serverName.AccessibleRole = AccessibleRole.TitleBar;
			lbl_serverName.AutoSize = true;
			lbl_serverName.Location = new Point(10, 113);
			lbl_serverName.Name = "lbl_serverName";
			lbl_serverName.Size = new Size(70, 15);
			lbl_serverName.TabIndex = 1;
			lbl_serverName.Text = "Data Source";
			// 
			// lbl_user
			// 
			lbl_user.AccessibleRole = AccessibleRole.TitleBar;
			lbl_user.AutoSize = true;
			lbl_user.Location = new Point(10, 154);
			lbl_user.Name = "lbl_user";
			lbl_user.Size = new Size(60, 15);
			lbl_user.TabIndex = 3;
			lbl_user.Text = "Username";
			// 
			// txbx_userame
			// 
			txbx_userame.AccessibleRole = AccessibleRole.TitleBar;
			txbx_userame.Location = new Point(90, 151);
			txbx_userame.Name = "txbx_userame";
			txbx_userame.Size = new Size(287, 23);
			txbx_userame.TabIndex = 2;
			// 
			// label1
			// 
			label1.AccessibleRole = AccessibleRole.TitleBar;
			label1.AutoSize = true;
			label1.Location = new Point(10, 202);
			label1.Name = "label1";
			label1.Size = new Size(57, 15);
			label1.TabIndex = 5;
			label1.Text = "Password";
			// 
			// txbx_password
			// 
			txbx_password.AccessibleRole = AccessibleRole.TitleBar;
			txbx_password.Location = new Point(90, 199);
			txbx_password.Name = "txbx_password";
			txbx_password.Size = new Size(287, 23);
			txbx_password.TabIndex = 4;
			// 
			// btn_OpenFile
			// 
			btn_OpenFile.Location = new Point(3, 138);
			btn_OpenFile.Name = "btn_OpenFile";
			btn_OpenFile.Size = new Size(381, 38);
			btn_OpenFile.TabIndex = 6;
			btn_OpenFile.Text = "Select Folder";
			btn_OpenFile.UseVisualStyleBackColor = true;
			btn_OpenFile.Click += btn_OpenFile_Click;
			// 
			// lsbx_fileFormat
			// 
			lsbx_fileFormat.FormattingEnabled = true;
			lsbx_fileFormat.ItemHeight = 15;
			lsbx_fileFormat.Items.AddRange(new object[] { ".SQL", ".TXT", ".MDF", ".BAK" });
			lsbx_fileFormat.Location = new Point(82, 74);
			lsbx_fileFormat.Name = "lsbx_fileFormat";
			lsbx_fileFormat.Size = new Size(288, 49);
			lsbx_fileFormat.TabIndex = 7;
			// 
			// label2
			// 
			label2.AccessibleRole = AccessibleRole.TitleBar;
			label2.AutoSize = true;
			label2.Location = new Point(3, 80);
			label2.Name = "label2";
			label2.Size = new Size(66, 15);
			label2.TabIndex = 8;
			label2.Text = "File Format";
			// 
			// label3
			// 
			label3.AccessibleRole = AccessibleRole.TitleBar;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label3.Location = new Point(3, 28);
			label3.Name = "label3";
			label3.Size = new Size(117, 28);
			label3.TabIndex = 9;
			label3.Text = "File Details";
			// 
			// label4
			// 
			label4.AccessibleRole = AccessibleRole.TitleBar;
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label4.Location = new Point(3, 12);
			label4.Name = "label4";
			label4.Size = new Size(191, 28);
			label4.TabIndex = 10;
			label4.Text = "Connection Details";
			// 
			// lsbx_allFiles
			// 
			lsbx_allFiles.Dock = DockStyle.Top;
			lsbx_allFiles.FormattingEnabled = true;
			lsbx_allFiles.ItemHeight = 15;
			lsbx_allFiles.Location = new Point(0, 43);
			lsbx_allFiles.Margin = new Padding(10);
			lsbx_allFiles.Name = "lsbx_allFiles";
			lsbx_allFiles.Size = new Size(689, 229);
			lsbx_allFiles.TabIndex = 11;
			// 
			// btn_execute
			// 
			btn_execute.BackColor = SystemColors.Control;
			btn_execute.Dock = DockStyle.Top;
			btn_execute.Font = new Font("Segoe UI", 12F);
			btn_execute.Location = new Point(0, 304);
			btn_execute.Name = "btn_execute";
			btn_execute.Size = new Size(689, 40);
			btn_execute.TabIndex = 12;
			btn_execute.Text = "Execute";
			btn_execute.UseVisualStyleBackColor = false;
			btn_execute.Click += ExecuteScript;
			// 
			// label5
			// 
			label5.AccessibleRole = AccessibleRole.TitleBar;
			label5.AutoSize = true;
			label5.Dock = DockStyle.Top;
			label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label5.Location = new Point(0, 15);
			label5.Name = "label5";
			label5.Size = new Size(171, 28);
			label5.TabIndex = 13;
			label5.Text = "Selection Details";
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.Controls.Add(label6);
			panel1.Controls.Add(lsbx_serverNames);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(txbx_dataSource);
			panel1.Controls.Add(lbl_serverName);
			panel1.Controls.Add(txbx_userame);
			panel1.Controls.Add(lbl_user);
			panel1.Controls.Add(txbx_password);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(427, 225);
			panel1.TabIndex = 14;
			// 
			// label6
			// 
			label6.AccessibleRole = AccessibleRole.TitleBar;
			label6.AutoSize = true;
			label6.Location = new Point(9, 75);
			label6.Name = "label6";
			label6.Size = new Size(79, 15);
			label6.TabIndex = 12;
			label6.Text = "Server Names";
			// 
			// lsbx_serverNames
			// 
			lsbx_serverNames.FormattingEnabled = true;
			lsbx_serverNames.ItemHeight = 15;
			lsbx_serverNames.Items.AddRange(new object[] { ".SQL", ".TXT", ".MDF", ".BAK" });
			lsbx_serverNames.Location = new Point(94, 75);
			lsbx_serverNames.Name = "lsbx_serverNames";
			lsbx_serverNames.Size = new Size(283, 19);
			lsbx_serverNames.TabIndex = 11;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3865242F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6134758F));
			tableLayoutPanel1.Controls.Add(panel3, 1, 0);
			tableLayoutPanel1.Controls.Add(panel4, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.Padding = new Padding(30);
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.77778F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(1188, 436);
			tableLayoutPanel1.TabIndex = 15;
			// 
			// panel3
			// 
			panel3.AutoSize = true;
			panel3.Controls.Add(btn_execute);
			panel3.Controls.Add(panel5);
			panel3.Controls.Add(lsbx_allFiles);
			panel3.Controls.Add(label5);
			panel3.Controls.Add(panel6);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(466, 33);
			panel3.Name = "panel3";
			panel3.Size = new Size(689, 370);
			panel3.TabIndex = 16;
			// 
			// panel5
			// 
			panel5.Dock = DockStyle.Top;
			panel5.Location = new Point(0, 272);
			panel5.Name = "panel5";
			panel5.Size = new Size(689, 32);
			panel5.TabIndex = 14;
			// 
			// panel6
			// 
			panel6.Dock = DockStyle.Top;
			panel6.Location = new Point(0, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(689, 15);
			panel6.TabIndex = 15;
			// 
			// panel4
			// 
			panel4.AutoSize = true;
			panel4.Controls.Add(panel2);
			panel4.Controls.Add(panel1);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(33, 33);
			panel4.Name = "panel4";
			panel4.Size = new Size(427, 370);
			panel4.TabIndex = 17;
			// 
			// panel2
			// 
			panel2.AutoSize = true;
			panel2.Controls.Add(label3);
			panel2.Controls.Add(btn_OpenFile);
			panel2.Controls.Add(lsbx_fileFormat);
			panel2.Controls.Add(label2);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 225);
			panel2.Name = "panel2";
			panel2.Size = new Size(427, 145);
			panel2.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1188, 436);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox txbx_serverName;
		private Label lbl_serverName;
		private Label lbl_user;
		private TextBox txbx_userame;
		private Label label1;
		private TextBox txbx_password;
		private Button btn_OpenFile;
		private FolderBrowserDialog folderBrowserDialog;
		private ListBox lsbx_fileFormat;
		private Label label2;
		private Label label3;
		private Label label4;
		private ListBox lsbx_allFiles;
		private Button btn_execute;
		private Label label5;
		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
		private Panel panel6;
		private TextBox textBox1;
		private Label label6;
		private ListBox lsbx_serverNames;
		private TextBox txbx_dataSource;
	}
}
