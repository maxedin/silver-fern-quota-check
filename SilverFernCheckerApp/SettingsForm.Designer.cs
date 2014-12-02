namespace SilverFernChecker
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonApply = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbWebSitePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWebSiteLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbPositiveKeyword = new System.Windows.Forms.TextBox();
            this.tbNegativeKeyword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxTo = new System.Windows.Forms.GroupBox();
            this.cbErrorsViaEmail = new System.Windows.Forms.CheckBox();
            this.buttonSendTestEmail = new System.Windows.Forms.Button();
            this.tbMailRecipient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.linkLabelCreateGmail = new System.Windows.Forms.LinkLabel();
            this.tbGmailUserPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGmailUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendSMS = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNotificationsViaSms = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxTo.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(185, 337);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(55, 23);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Ok";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApplyClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 331);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWebSitePassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbWebSiteLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Immigration Website";
            // 
            // tbWebSitePassword
            // 
            this.tbWebSitePassword.Location = new System.Drawing.Point(9, 85);
            this.tbWebSitePassword.Name = "tbWebSitePassword";
            this.tbWebSitePassword.PasswordChar = '*';
            this.tbWebSitePassword.Size = new System.Drawing.Size(256, 20);
            this.tbWebSitePassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // tbWebSiteLogin
            // 
            this.tbWebSiteLogin.Location = new System.Drawing.Point(9, 33);
            this.tbWebSiteLogin.Name = "tbWebSiteLogin";
            this.tbWebSiteLogin.Size = new System.Drawing.Size(256, 20);
            this.tbWebSiteLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tbPositiveKeyword);
            this.tabPage5.Controls.Add(this.tbNegativeKeyword);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(297, 305);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Key words";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbPositiveKeyword
            // 
            this.tbPositiveKeyword.Location = new System.Drawing.Point(11, 108);
            this.tbPositiveKeyword.Name = "tbPositiveKeyword";
            this.tbPositiveKeyword.Size = new System.Drawing.Size(270, 20);
            this.tbPositiveKeyword.TabIndex = 3;
            // 
            // tbNegativeKeyword
            // 
            this.tbNegativeKeyword.Location = new System.Drawing.Point(11, 35);
            this.tbNegativeKeyword.Name = "tbNegativeKeyword";
            this.tbNegativeKeyword.Size = new System.Drawing.Size(270, 20);
            this.tbNegativeKeyword.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Positive key word that tells \"quota availible\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Negative key word that tells \"no quota availible\"";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxTo);
            this.tabPage2.Controls.Add(this.cbEmail);
            this.tabPage2.Controls.Add(this.groupBoxFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxTo
            // 
            this.groupBoxTo.Controls.Add(this.cbErrorsViaEmail);
            this.groupBoxTo.Controls.Add(this.buttonSendTestEmail);
            this.groupBoxTo.Controls.Add(this.tbMailRecipient);
            this.groupBoxTo.Controls.Add(this.label6);
            this.groupBoxTo.Location = new System.Drawing.Point(8, 197);
            this.groupBoxTo.Name = "groupBoxTo";
            this.groupBoxTo.Size = new System.Drawing.Size(285, 105);
            this.groupBoxTo.TabIndex = 11;
            this.groupBoxTo.TabStop = false;
            this.groupBoxTo.Text = "Send To";
            // 
            // cbErrorsViaEmail
            // 
            this.cbErrorsViaEmail.AutoSize = true;
            this.cbErrorsViaEmail.Location = new System.Drawing.Point(9, 82);
            this.cbErrorsViaEmail.Name = "cbErrorsViaEmail";
            this.cbErrorsViaEmail.Size = new System.Drawing.Size(116, 17);
            this.cbErrorsViaEmail.TabIndex = 12;
            this.cbErrorsViaEmail.Text = "Get errors via email";
            this.cbErrorsViaEmail.UseVisualStyleBackColor = true;
            // 
            // buttonSendTestEmail
            // 
            this.buttonSendTestEmail.Location = new System.Drawing.Point(161, 59);
            this.buttonSendTestEmail.Name = "buttonSendTestEmail";
            this.buttonSendTestEmail.Size = new System.Drawing.Size(106, 23);
            this.buttonSendTestEmail.TabIndex = 5;
            this.buttonSendTestEmail.Text = "Send test email";
            this.buttonSendTestEmail.UseVisualStyleBackColor = true;
            this.buttonSendTestEmail.Click += new System.EventHandler(this.ButtonSendTestEmailClick);
            // 
            // tbMailRecipient
            // 
            this.tbMailRecipient.Location = new System.Drawing.Point(9, 33);
            this.tbMailRecipient.Name = "tbMailRecipient";
            this.tbMailRecipient.Size = new System.Drawing.Size(258, 20);
            this.tbMailRecipient.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Your email";
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Checked = true;
            this.cbEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEmail.Location = new System.Drawing.Point(15, 165);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(146, 17);
            this.cbEmail.TabIndex = 4;
            this.cbEmail.Text = "Get notifications via email";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.CbEmailCheckedChanged);
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.linkLabelCreateGmail);
            this.groupBoxFrom.Controls.Add(this.tbGmailUserPass);
            this.groupBoxFrom.Controls.Add(this.label3);
            this.groupBoxFrom.Controls.Add(this.tbGmailUserName);
            this.groupBoxFrom.Controls.Add(this.label4);
            this.groupBoxFrom.Location = new System.Drawing.Point(6, 6);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(285, 144);
            this.groupBoxFrom.TabIndex = 10;
            this.groupBoxFrom.TabStop = false;
            this.groupBoxFrom.Text = "Gmail account";
            // 
            // linkLabelCreateGmail
            // 
            this.linkLabelCreateGmail.AutoSize = true;
            this.linkLabelCreateGmail.Location = new System.Drawing.Point(158, 116);
            this.linkLabelCreateGmail.Name = "linkLabelCreateGmail";
            this.linkLabelCreateGmail.Size = new System.Drawing.Size(109, 13);
            this.linkLabelCreateGmail.TabIndex = 5;
            this.linkLabelCreateGmail.TabStop = true;
            this.linkLabelCreateGmail.Text = "Create Gmail account";
            this.linkLabelCreateGmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCreateGmailLinkClicked);
            // 
            // tbGmailUserPass
            // 
            this.tbGmailUserPass.Location = new System.Drawing.Point(9, 83);
            this.tbGmailUserPass.Name = "tbGmailUserPass";
            this.tbGmailUserPass.PasswordChar = '*';
            this.tbGmailUserPass.Size = new System.Drawing.Size(258, 20);
            this.tbGmailUserPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // tbGmailUserName
            // 
            this.tbGmailUserName.Location = new System.Drawing.Point(9, 33);
            this.tbGmailUserName.Name = "tbGmailUserName";
            this.tbGmailUserName.Size = new System.Drawing.Size(258, 20);
            this.tbGmailUserName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Login (example@gmail.com)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.cbNotificationsViaSms);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(297, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SMS (beta)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendSMS);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 260);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How to set up?";
            // 
            // btnSendSMS
            // 
            this.btnSendSMS.Location = new System.Drawing.Point(175, 176);
            this.btnSendSMS.Name = "btnSendSMS";
            this.btnSendSMS.Size = new System.Drawing.Size(102, 23);
            this.btnSendSMS.TabIndex = 2;
            this.btnSendSMS.Text = "Send test SMS";
            this.btnSendSMS.UseVisualStyleBackColor = true;
            this.btnSendSMS.Click += new System.EventHandler(this.btnSendSMS_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(142, 143);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Mobile Setup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 156);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // cbNotificationsViaSms
            // 
            this.cbNotificationsViaSms.AutoSize = true;
            this.cbNotificationsViaSms.Checked = true;
            this.cbNotificationsViaSms.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNotificationsViaSms.Location = new System.Drawing.Point(15, 16);
            this.cbNotificationsViaSms.Name = "cbNotificationsViaSms";
            this.cbNotificationsViaSms.Size = new System.Drawing.Size(224, 17);
            this.cbNotificationsViaSms.TabIndex = 5;
            this.cbNotificationsViaSms.Text = "Get notifications via SMS if quota availible";
            this.cbNotificationsViaSms.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(297, 305);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Custom action";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Controls.Add(this.tbFilePath);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 97);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run file if quota availible";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(202, 57);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(6, 31);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(271, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(246, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(305, 366);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings silver-fern-quota-check";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxTo.ResumeLayout(false);
            this.groupBoxTo.PerformLayout();
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWebSitePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWebSiteLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxTo;
        private System.Windows.Forms.Button buttonSendTestEmail;
        private System.Windows.Forms.TextBox tbMailRecipient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.LinkLabel linkLabelCreateGmail;
        private System.Windows.Forms.TextBox tbGmailUserPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGmailUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbErrorsViaEmail;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbNotificationsViaSms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnSendSMS;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbPositiveKeyword;
        private System.Windows.Forms.TextBox tbNegativeKeyword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}