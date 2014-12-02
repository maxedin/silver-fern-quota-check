namespace SilverFernChecker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheckingInterval = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonProjectWebpage = new System.Windows.Forms.ToolStripButton();
            this.ButtonFeedback = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.contextMenuTrayIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuTrayIcon;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Silver Fern Visa Checker";
            this.trayIcon.Visible = true;
            this.trayIcon.BalloonTipClicked += new System.EventHandler(this.TrayIconBalloonTipClicked);
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconMouseDoubleClick);
            // 
            // contextMenuTrayIcon
            // 
            this.contextMenuTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuTrayIcon.Name = "contextMenuTrayIcon";
            this.contextMenuTrayIcon.ShowImageMargin = false;
            this.contextMenuTrayIcon.Size = new System.Drawing.Size(80, 54);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(76, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // timerCheckingInterval
            // 
            this.timerCheckingInterval.Enabled = true;
            this.timerCheckingInterval.Interval = 1000;
            this.timerCheckingInterval.Tick += new System.EventHandler(this.TimerTick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(668, 262);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonReset,
            this.toolStripSeparator5,
            this.ButtonSettings,
            this.toolStripSeparator7,
            this.ButtonProjectWebpage,
            this.ButtonFeedback,
            this.toolStripSeparator6,
            this.ButtonExit,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 55);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("ButtonReset.Image")));
            this.ButtonReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(163, 52);
            this.ButtonReset.Text = "Next check in 0 min";
            this.ButtonReset.ToolTipText = "Start new check and reset timer";
            this.ButtonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSettings.Image")));
            this.ButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(52, 52);
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 55);
            // 
            // ButtonProjectWebpage
            // 
            this.ButtonProjectWebpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonProjectWebpage.Image = ((System.Drawing.Image)(resources.GetObject("ButtonProjectWebpage.Image")));
            this.ButtonProjectWebpage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonProjectWebpage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonProjectWebpage.Name = "ButtonProjectWebpage";
            this.ButtonProjectWebpage.Size = new System.Drawing.Size(52, 52);
            this.ButtonProjectWebpage.Text = "Visit project page";
            this.ButtonProjectWebpage.Click += new System.EventHandler(this.ButtonProjectWebpage_Click);
            // 
            // ButtonFeedback
            // 
            this.ButtonFeedback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonFeedback.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFeedback.Image")));
            this.ButtonFeedback.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonFeedback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonFeedback.Name = "ButtonFeedback";
            this.ButtonFeedback.Size = new System.Drawing.Size(52, 52);
            this.ButtonFeedback.Text = "Feedback";
            this.ButtonFeedback.Click += new System.EventHandler(this.ButtonFeedbackClick);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(52, 52);
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(668, 213);
            this.webBrowser.TabIndex = 5;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserDocumentCompleted);
            // 
            // listBoxLog
            // 
            this.listBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxLog.Location = new System.Drawing.Point(0, 0);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(668, 45);
            this.listBoxLog.TabIndex = 0;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 60000;
            this.timerCountdown.Tick += new System.EventHandler(this.TimerCountdownTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 262);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Silver Fern Checker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.contextMenuTrayIcon.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerCheckingInterval;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ButtonFeedback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ButtonExit;
        private System.Windows.Forms.ToolStripButton ButtonReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton ButtonSettings;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonProjectWebpage;
    }
}

