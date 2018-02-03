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
		
		private string host;
		private int port;
		private string user;
		private string password;
		
		private string localFolder;
		private string remoteFolder;
		
		public MainForm()
		{
			InitializeComponent();
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
			host = FTPHost.Text;
			port = int.Parse(FTPPort.Value.ToString());
			user = FTPUser.Text;
			password = FTPPassword.Text;
			localFolder = textBoxLocalFolder.Text;
			remoteFolder = TextBoxRemoteFolder.Text;
		}
	}
}
