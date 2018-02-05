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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Threading;

namespace FTPsync
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	public partial class MainForm : Form
	{
		private FTP FTPConnection;
		private Dictionary<string, string> options;
		private List<LocalFile> localFiles = new List<LocalFile>();
		private List<RemoteFile> remoteFiles = new List<RemoteFile>();
		private bool sync;
		
		private Thread thread;
		private Thread watcher;
		
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
			checkBoxCache.Checked = bool.Parse(options["cache"]);

			sync = false;
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			SaveFTPConnection();
			LoadFTPConnection();
		}

		void ToolStripTurnOnClick(object sender, EventArgs e)
		{
			if(sync == false)
			{
				thread = new Thread(LoadFiles);
				thread.Start();
			}
			else
			{
				if(thread != null)
					thread.Abort();
				if(watcher != null)
					watcher.Abort();
			}
			
			sync = !sync;
			toolStripSwitchSync.Checked = !toolStripSwitchSync.Checked;
		}
		
		void ButtonSelectLocalFolderClick(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				textBoxLocalFolder.Text = dialog.SelectedPath;
			}
		}
		
		private void Log(string msg)
		{
			if(textBoxLog.InvokeRequired)
			{
				StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(Log);  
        		this.Invoke(d, new object[] { msg });  
			}
			else
			{
				textBoxLog.AppendText(msg + Environment.NewLine);
			}
		}
		
		private void LoadFTPConnection()
		{
			options["host"] = FTPHost.Text;
			options["post"] = FTPPort.Value.ToString();
			options["user"] = FTPUser.Text;
			options["password"] = FTPPassword.Text;
			options["localFolder"] = textBoxLocalFolder.Text;
			options["remoteFolder"] = TextBoxRemoteFolder.Text;
			options["autoSync"] = checkBoxAutoSync.Checked.ToString();
			options["cache"] = checkBoxCache.Checked.ToString();
		}
		
		private void LoadFiles()
		{
			ClearStatus();
			
			if(bool.Parse(options["cache"]) == true)
			{
				if(TryLoadCache()) {
					Log("Files loaded from cache");
					Log("Local files loaded("+localFiles.Count+")");
					Log("Remote files loaded("+remoteFiles.Count+")");
					
					watcher = new Thread(Watch);
					watcher.Start();
					
					return;
				}
			}
			
			LoadLocalFiles(options["localFolder"]);
			Log("Local files loaded("+localFiles.Count+")");
			LoadRemoteFiles(options["remoteFolder"]);
			Log("Remote files loaded("+remoteFiles.Count+")");
			
			watcher = new Thread(Watch);
			watcher.Start();
			
			if(bool.Parse(options["cache"]) == true) {
				SaveFilesLists();
			}
		}
		
		private void LoadLocalFiles(string dir)
		{
			if(Directory.Exists(dir))
			{
				foreach(string file in Directory.GetFiles(dir)) {
					LocalFile localFile = new LocalFile();
					localFile.fullPath = file;
					localFile.fileName = file.Split('\\')[file.Split('\\').Length-1];
					localFile.lastEdited = File.GetLastAccessTime(file);
					
					localFiles.Add(localFile);
				}
				
				foreach(string folder in Directory.GetDirectories(dir)) {
					LoadLocalFiles(folder);
				}
			}
		}
		
		private void LoadRemoteFiles(string dir)
		{
			FTPConnection = new FTP("ftp://"+options["host"], options["user"], options["password"]);
			
			statusStrip.Text = "Analyzing "+dir;
			
			foreach(string el in FTPConnection.directoryListDetailed(dir))
			{
				if(el.Trim().StartsWith("-"))
				{
					Regex reg = new Regex("[ ]{2,}", RegexOptions.None);
					string[] arr = reg.Replace(el, " ").Split(' ');
					
					RemoteFile file = new RemoteFile();
					file.fileName = arr[8];
					file.fullPath = dir+"/"+arr[8];
					file.lastEdited = DateTime.Parse(arr[5]+" "+arr[6]+" "+arr[7]);
					remoteFiles.Add(file);
				}
				else if(el.Trim().StartsWith("d"))
				{
					Regex reg = new Regex("[ ]{2,}", RegexOptions.None);
					string[] arr = reg.Replace(el, " ").Split(' ');
					if(arr[8] != "." && arr[8] != "..")
						LoadRemoteFiles(dir+"/"+arr[8]);
				}
			}
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
				                   	"autoSync:"+checkBoxAutoSync.Checked.ToString(),
				                   	"cache:"+checkBoxCache.Checked.ToString()
				                   }
				);
				statusStrip.Text = "Succesfully saved settings";
			}
			catch(Exception ex) {
				MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void SaveFilesLists()
		{
			File.WriteAllText(@"data\localFiles.txt", String.Empty);
			File.WriteAllText(@"data\remoteFiles.txt", String.Empty);
			
			foreach(LocalFile file in localFiles)
			{
				File.AppendAllLines(@"data\localFiles.txt", new string[] {file.fileName+" "+file.fullPath+" "+file.lastEdited.ToString()});
			}
			
			foreach(RemoteFile file in remoteFiles)
			{
				File.AppendAllLines(@"data\remoteFiles.txt", new string[] {file.fileName+" "+file.fullPath+" "+file.lastEdited.ToString()});
			}
		}
		
		private bool TryLoadCache()
		{
			localFiles.Clear();
			remoteFiles.Clear();
			try {
				foreach(string line in File.ReadAllLines("data/localFiles.txt"))
				{
					LocalFile file = new LocalFile();
					string[] arr = line.Split(' ');
					
					file.fullPath = arr[0];
					file.fileName = arr[1];
					file.lastEdited = DateTime.Parse(arr[2]);
					
					localFiles.Add(file);
				}
				
				foreach(string line in File.ReadAllLines("data/remoteFiles.txt"))
				{
					RemoteFile file = new RemoteFile();
					string[] arr = line.Split(' ');
					
					file.fullPath = arr[0];
					file.fileName = arr[1];
					file.lastEdited = DateTime.Parse(arr[2]);
					
					remoteFiles.Add(file);
				}
			}
			catch {
				return false;
			}
			return true;
		}
		
		private void Watch()
		{
			foreach(LocalFile local in localFiles)
			{
				foreach(RemoteFile remote in remoteFiles)
				{
					if(local.lastEdited > remote.lastEdited)
					{
						AppendStatus(local.fullPath);
					}
				}
			}
			
			Thread.Sleep(1000);
			Watch();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(this.thread != null) {
				thread.Abort();
			}
			if(this.watcher != null) {
				watcher.Abort();
			}
		}
		
		private void ClearStatus()
		{
			if(textBoxStatus.InvokeRequired)
			{
				NoArgsReturningVoidDeletage d = new NoArgsReturningVoidDeletage(ClearStatus);  
        		this.Invoke(d, new object[] {});  
			}
			else
			{
				textBoxStatus.Clear();
			}
		}
		
		private void AppendStatus(string msg)
		{
			if(textBoxStatus.InvokeRequired)
			{
				StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AppendStatus);  
        		this.Invoke(d, new object[] {});  
			}
			else
			{
				textBoxStatus.AppendText(msg + Environment.NewLine);
			}
		}
	}
	
	
	
	delegate void StringArgReturningVoidDelegate(string text);
	delegate void NoArgsReturningVoidDeletage();
}
