/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-03
 * Time: 13:36
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FTPsync
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		private FTP FTPConnection;
		private Dictionary<string, string> options;
		
		private string host;
		private int port;
		private string user;
		private string password;
		
		private string localFolder;
		private string remoteFolder;
		
		public MainForm()
		{
			InitializeComponent();
			options = IniFile.ReadAllOptions("settings.ini");
			options["localFolder"] = options["localFolder"].Replace(';', ':');
			
			FTPHost.Text = options["host"];
			FTPPort.Value = int.Parse(options["port"]);
			FTPUser.Text = options["user"];
			FTPPassword.Text = options["password"];
			
			textBoxLocalFolder.Text = options["localFolder"];
			TextBoxRemoteFolder.Text = options["remoteFolder"];
		}
		
		
		void ButtonSelectLocalFolderClick(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				textBoxLocalFolder.Text = dialog.SelectedPath;
			}
		}
		
		void ConnectToolStripMenuItemClick(object sender, EventArgs e)
		{
			LoadFTPConnection();
			FTPConnection = new FTP(@"ftp://"+host, user, password);
			
		}
		
		private void LoadFTPConnection()
		{
			options["host"] = FTPHost.Text;
			options["post"] = FTPPort.Value.ToString();
			options["user"] = user = FTPUser.Text;
			options["password"] = password = FTPPassword.Text;
			options["localFolder"] = localFolder = textBoxLocalFolder.Text;
			options["remoteFolder"] = remoteFolder = TextBoxRemoteFolder.Text;
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			SaveFTPConnection();
		}
		
		private void SaveFTPConnection()
		{
			File.WriteAllLines("settings.ini", new string[]
			                   {
			                   	"# FTP connection",
			                   	"host:"+FTPHost.Text,
			                   	"port:"+FTPPort.Value.ToString(),
			                   	"user:"+FTPUser.Text,
			                   	"password:"+FTPPassword.Text,
			                   	"",
			                   	"# settings",
			                   	"localFolder:"+textBoxLocalFolder.Text.Replace(':', ';'),
			                   	"remoteFolder:"+TextBoxRemoteFolder.Text.Replace(':', ';')
			                   }
			);
		}
	}
}
