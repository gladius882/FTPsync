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
		private List<string> localFiles = new List<string>();
		private List<string> RemoteFiles = new List<string>();
		
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
			checkBoxAutoSync.Checked = bool.Parse(options["autoSync"]);
			
			if(bool.Parse(options["autoSync"]) == true)
			{
				LoadLocalFiles(options["localFolder"]);
			}
			
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
			FTPConnection = new FTP(@"ftp://"+options["host"], options["user"], options["host"]);
			
		}
		
		private void LoadFTPConnection()
		{
			options["host"] = FTPHost.Text;
			options["post"] = FTPPort.Value.ToString();
			options["user"] = FTPUser.Text;
			options["password"] = FTPPassword.Text;
			options["localFolder"] = textBoxLocalFolder.Text;
			options["remoteFolder"] = TextBoxRemoteFolder.Text;
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			SaveFTPConnection();
		}
		
		private void SaveFTPConnection()
		{
			try {
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
				                   	"remoteFolder:"+TextBoxRemoteFolder.Text.Replace(':', ';'),
				                   	"autoSync:"+checkBoxAutoSync.Checked.ToString()
				                   }
				);
				statusStrip.Text = "Succesfully saved settings";
			}
			catch(Exception ex) {
				MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void LoadLocalFiles(string dir)
		{
			if(Directory.Exists(dir))
			{
				string[] files = Directory.GetFiles(dir);
				foreach(string file in Directory.GetFiles(dir))
				{
					localFiles.Add(file);
				}
				string[] folders = Directory.GetDirectories(dir);
				foreach(string folder in Directory.GetDirectories(dir))
				{
					LoadLocalFiles(folder);
				}
			}
		}
	}
}
