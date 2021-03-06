﻿/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-02-03
 * Time: 13:36
 * 
 */
namespace FTPsync
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabStatus;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.TabPage tabConfig;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusStrip;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown FTPPort;
		private System.Windows.Forms.TextBox FTPPassword;
		private System.Windows.Forms.TextBox FTPUser;
		private System.Windows.Forms.TextBox FTPHost;
		private System.Windows.Forms.TabPage tabLog;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonSelectLocalFolder;
		private System.Windows.Forms.TextBox TextBoxRemoteFolder;
		private System.Windows.Forms.TextBox textBoxLocalFolder;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.CheckBox checkBoxAutoSync;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripSwitchSync;
		private System.Windows.Forms.TabPage tabHelp;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.CheckBox checkBoxCache;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabStatus = new System.Windows.Forms.TabPage();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.tabLog = new System.Windows.Forms.TabPage();
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.tabConfig = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxCache = new System.Windows.Forms.CheckBox();
			this.checkBoxAutoSync = new System.Windows.Forms.CheckBox();
			this.buttonSelectLocalFolder = new System.Windows.Forms.Button();
			this.TextBoxRemoteFolder = new System.Windows.Forms.TextBox();
			this.textBoxLocalFolder = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonSave = new System.Windows.Forms.Button();
			this.FTPPort = new System.Windows.Forms.NumericUpDown();
			this.FTPPassword = new System.Windows.Forms.TextBox();
			this.FTPUser = new System.Windows.Forms.TextBox();
			this.FTPHost = new System.Windows.Forms.TextBox();
			this.tabHelp = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSwitchSync = new System.Windows.Forms.ToolStripButton();
			this.tabControl.SuspendLayout();
			this.tabStatus.SuspendLayout();
			this.tabLog.SuspendLayout();
			this.tabConfig.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FTPPort)).BeginInit();
			this.tabHelp.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabStatus);
			this.tabControl.Controls.Add(this.tabLog);
			this.tabControl.Controls.Add(this.tabConfig);
			this.tabControl.Controls.Add(this.tabHelp);
			this.tabControl.Location = new System.Drawing.Point(0, 28);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(479, 237);
			this.tabControl.TabIndex = 1;
			// 
			// tabStatus
			// 
			this.tabStatus.BackColor = System.Drawing.Color.Transparent;
			this.tabStatus.Controls.Add(this.textBoxStatus);
			this.tabStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tabStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.tabStatus.Location = new System.Drawing.Point(4, 22);
			this.tabStatus.Name = "tabStatus";
			this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
			this.tabStatus.Size = new System.Drawing.Size(471, 211);
			this.tabStatus.TabIndex = 0;
			this.tabStatus.Text = "Status";
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxStatus.Enabled = false;
			this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxStatus.Location = new System.Drawing.Point(3, 3);
			this.textBoxStatus.Multiline = true;
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(465, 205);
			this.textBoxStatus.TabIndex = 0;
			this.textBoxStatus.Text = "Please turn on sync to start watching changes in files";
			// 
			// tabLog
			// 
			this.tabLog.Controls.Add(this.textBoxLog);
			this.tabLog.Location = new System.Drawing.Point(4, 22);
			this.tabLog.Name = "tabLog";
			this.tabLog.Size = new System.Drawing.Size(471, 211);
			this.tabLog.TabIndex = 2;
			this.tabLog.Text = "Log";
			this.tabLog.UseVisualStyleBackColor = true;
			// 
			// textBoxLog
			// 
			this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxLog.Enabled = false;
			this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxLog.Location = new System.Drawing.Point(0, 0);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.Size = new System.Drawing.Size(471, 211);
			this.textBoxLog.TabIndex = 0;
			// 
			// tabConfig
			// 
			this.tabConfig.Controls.Add(this.groupBox2);
			this.tabConfig.Controls.Add(this.groupBox1);
			this.tabConfig.Location = new System.Drawing.Point(4, 22);
			this.tabConfig.Name = "tabConfig";
			this.tabConfig.Size = new System.Drawing.Size(471, 211);
			this.tabConfig.TabIndex = 1;
			this.tabConfig.Text = "Config";
			this.tabConfig.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxCache);
			this.groupBox2.Controls.Add(this.checkBoxAutoSync);
			this.groupBox2.Controls.Add(this.buttonSelectLocalFolder);
			this.groupBox2.Controls.Add(this.TextBoxRemoteFolder);
			this.groupBox2.Controls.Add(this.textBoxLocalFolder);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(214, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(249, 187);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			// 
			// checkBoxCache
			// 
			this.checkBoxCache.Location = new System.Drawing.Point(7, 156);
			this.checkBoxCache.Name = "checkBoxCache";
			this.checkBoxCache.Size = new System.Drawing.Size(104, 24);
			this.checkBoxCache.TabIndex = 4;
			this.checkBoxCache.Text = "Use cache";
			this.checkBoxCache.UseVisualStyleBackColor = true;
			// 
			// checkBoxAutoSync
			// 
			this.checkBoxAutoSync.Location = new System.Drawing.Point(7, 125);
			this.checkBoxAutoSync.Name = "checkBoxAutoSync";
			this.checkBoxAutoSync.Size = new System.Drawing.Size(206, 24);
			this.checkBoxAutoSync.TabIndex = 3;
			this.checkBoxAutoSync.Text = "Automatically send when file changed";
			this.checkBoxAutoSync.UseVisualStyleBackColor = true;
			// 
			// buttonSelectLocalFolder
			// 
			this.buttonSelectLocalFolder.Location = new System.Drawing.Point(219, 46);
			this.buttonSelectLocalFolder.Name = "buttonSelectLocalFolder";
			this.buttonSelectLocalFolder.Size = new System.Drawing.Size(24, 20);
			this.buttonSelectLocalFolder.TabIndex = 2;
			this.buttonSelectLocalFolder.Text = "...";
			this.buttonSelectLocalFolder.UseVisualStyleBackColor = true;
			this.buttonSelectLocalFolder.Click += new System.EventHandler(this.ButtonSelectLocalFolderClick);
			// 
			// TextBoxRemoteFolder
			// 
			this.TextBoxRemoteFolder.Location = new System.Drawing.Point(6, 98);
			this.TextBoxRemoteFolder.Name = "TextBoxRemoteFolder";
			this.TextBoxRemoteFolder.Size = new System.Drawing.Size(237, 20);
			this.TextBoxRemoteFolder.TabIndex = 1;
			// 
			// textBoxLocalFolder
			// 
			this.textBoxLocalFolder.Location = new System.Drawing.Point(6, 46);
			this.textBoxLocalFolder.Name = "textBoxLocalFolder";
			this.textBoxLocalFolder.Size = new System.Drawing.Size(207, 20);
			this.textBoxLocalFolder.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Remote folder";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Local folder";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Local folder";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.FTPPort);
			this.groupBox1.Controls.Add(this.FTPPassword);
			this.groupBox1.Controls.Add(this.FTPUser);
			this.groupBox1.Controls.Add(this.FTPHost);
			this.groupBox1.Location = new System.Drawing.Point(8, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 169);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "FTP connection";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(6, 140);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// FTPPort
			// 
			this.FTPPort.Location = new System.Drawing.Point(7, 46);
			this.FTPPort.Name = "FTPPort";
			this.FTPPort.Size = new System.Drawing.Size(187, 20);
			this.FTPPort.TabIndex = 3;
			this.FTPPort.Value = new decimal(new int[] {
			21,
			0,
			0,
			0});
			// 
			// FTPPassword
			// 
			this.FTPPassword.Location = new System.Drawing.Point(6, 98);
			this.FTPPassword.Name = "FTPPassword";
			this.FTPPassword.Size = new System.Drawing.Size(187, 20);
			this.FTPPassword.TabIndex = 2;
			this.FTPPassword.UseSystemPasswordChar = true;
			// 
			// FTPUser
			// 
			this.FTPUser.Location = new System.Drawing.Point(7, 72);
			this.FTPUser.Name = "FTPUser";
			this.FTPUser.Size = new System.Drawing.Size(187, 20);
			this.FTPUser.TabIndex = 1;
			// 
			// FTPHost
			// 
			this.FTPHost.Location = new System.Drawing.Point(7, 20);
			this.FTPHost.Name = "FTPHost";
			this.FTPHost.Size = new System.Drawing.Size(187, 20);
			this.FTPHost.TabIndex = 0;
			// 
			// tabHelp
			// 
			this.tabHelp.Controls.Add(this.richTextBox1);
			this.tabHelp.Location = new System.Drawing.Point(4, 22);
			this.tabHelp.Name = "tabHelp";
			this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
			this.tabHelp.Size = new System.Drawing.Size(471, 211);
			this.tabHelp.TabIndex = 3;
			this.tabHelp.Text = "Help";
			this.tabHelp.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(465, 205);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.statusStrip});
			this.statusStrip1.Location = new System.Drawing.Point(0, 268);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(479, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusStrip
			// 
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(79, 17);
			this.statusStrip.Text = "Disconnected";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripSwitchSync});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(479, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSwitchSync
			// 
			this.toolStripSwitchSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSwitchSync.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSwitchSync.Image")));
			this.toolStripSwitchSync.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSwitchSync.Name = "toolStripSwitchSync";
			this.toolStripSwitchSync.Size = new System.Drawing.Size(23, 22);
			this.toolStripSwitchSync.Text = "Turn on/off sync";
			this.toolStripSwitchSync.Click += new System.EventHandler(this.ToolStripTurnOnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 290);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "FTPsync";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.tabControl.ResumeLayout(false);
			this.tabStatus.ResumeLayout(false);
			this.tabStatus.PerformLayout();
			this.tabLog.ResumeLayout(false);
			this.tabLog.PerformLayout();
			this.tabConfig.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FTPPort)).EndInit();
			this.tabHelp.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
