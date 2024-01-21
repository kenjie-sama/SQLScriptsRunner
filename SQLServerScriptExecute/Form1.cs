using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Data.Sql;

namespace SQLServerScriptExecute
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lsbx_fileFormat.SelectedIndex = 0;
			LoadServers();
		}

		private void btn_OpenFile_Click(object sender, EventArgs e)
		{

			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				Debug.WriteLine(GetConnectionString());
				lsbx_allFiles.Items.Clear();
				Debug.WriteLine(folderBrowserDialog.SelectedPath);
				FileInfo[] files = new DirectoryInfo(folderBrowserDialog.SelectedPath).GetFiles("*" + lsbx_fileFormat.Text.ToLower());
				try
				{
					List<FileInfo> sortedFiles = files.OrderBy(f => f.CreationTime).ToList();
					foreach (FileInfo file in sortedFiles)
						lsbx_allFiles.Items.Add(file.FullName);
				}
				catch (Exception ex)
				{
					Notification.Alert(ex);
				}

			}

		}

		private void ExecuteScript(object sender, EventArgs e)
		{
			using SqlConnection connection = new(GetConnectionString());
			try
			{
				connection.Open();
				foreach (string file in lsbx_allFiles.Items)
				{
					using (SqlCommand command = new(file, connection))
					{
						try
						{
							command.ExecuteNonQuery();
							Debug.WriteLine($"Script executed successfully! Filename: {file}");
						}
						catch (Exception ex)
						{
							Notification.Log(ex, "Reading: " + file);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Notification.Alert(ex);
			}
		}

		private string GetConnectionString() => $"Data Source={GetValidValue(txbx_serverName)};" +
				$"Persist Security Info=True;" + ValidateSecurity();
		private string GetValidValue(TextBox textBox) => String.IsNullOrEmpty(textBox.Text) ? "\"\"" : textBox.Text;
		private string ValidateSecurity()
		{
			string userID = GetValidValue(txbx_userame);
			string password = GetValidValue(txbx_password);

			bool userHasContent = userID != "\"\"";
			bool passwordHasContent = password != "\"\"";

			return userHasContent && passwordHasContent ? userID + password : "Integrated Security=SSPI;";
		}

		private void LoadServers()
		{
			try
			{
				var dataSources = SqlDataSourceEnumerator.Instance.GetDataSources();
				foreach (var row in dataSources.Rows)
				{
					lsbx_serverNames.Items.Add(row);
				}
			}
			catch (Exception ex)
			{
				Notification.Alert(ex);
			}
		}
	}
}
