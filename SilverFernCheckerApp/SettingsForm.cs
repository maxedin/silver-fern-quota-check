using System;
using System.Diagnostics;
using System.Windows.Forms;
using SilverFernCheckerCore.Helpers;
using SilverFernCheckerCore.Settings;

namespace SilverFernChecker
{
    public partial class SettingsForm : Form
    {
        private readonly Settings _settings = new Settings();

        public SettingsForm()
        {
            InitializeComponent();
            tbWebSiteLogin.Text = _settings.WebSiteLogin;
            tbWebSitePassword.Text = _settings.WebSitePass;
            tbGmailUserName.Text = _settings.GmailUserName;
            tbGmailUserPass.Text = _settings.GmailUserPassword;
            tbMailRecipient.Text = _settings.MailRecipient;
            cbEmail.Checked = _settings.NotificationViaEmail;
            cbErrorsViaEmail.Checked = _settings.ErrorsViaEmail;
            cbNotificationsViaSms.Checked = _settings.NotificationViaSms;
            tbFilePath.Text = _settings.CustomActionFilePath;
            tbNegativeKeyword.Text = _settings.WebSiteQuotaPageNegotiveeString;
            tbPositiveKeyword.Text = _settings.WebSiteQuotaPagePositiveString;
        }

        private void ButtonApplyClick(object sender, EventArgs e)
        {
            //save settings
            if (!tbGmailUserName.Text.ToLower().Contains("@gmail.com") && cbEmail.Checked)
            {
                MessageBox.Show("Login should be in format mymail@gmail.com","Incorrect data");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbWebSiteLogin.Text) || string.IsNullOrWhiteSpace(tbWebSitePassword.Text))
            {
                MessageBox.Show("Please enter website login and password", "Incorrect data");
                return;
            }
            _settings.WebSiteLogin = tbWebSiteLogin.Text;
            _settings.WebSitePass = tbWebSitePassword.Text;
            _settings.GmailUserName = tbGmailUserName.Text;
            _settings.GmailUserPassword = tbGmailUserPass.Text;
            _settings.MailRecipient = tbMailRecipient.Text;
            _settings.NotificationViaEmail = cbEmail.Checked;
            _settings.ErrorsViaEmail = cbErrorsViaEmail.Checked;
            _settings.NotificationViaSms = cbNotificationsViaSms.Checked;
            _settings.CustomActionFilePath = tbFilePath.Text;
            _settings.WebSiteQuotaPageNegotiveeString = tbNegativeKeyword.Text;
            _settings.WebSiteQuotaPagePositiveString = tbPositiveKeyword.Text;
            DialogResult = DialogResult.OK;
            this.Cursor = Cursors.WaitCursor;
            this.Close();
        }

        private void LinkLabelCreateGmailLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://accounts.google.com/SignUp?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ltmpl=default");
        }

        private void CbEmailCheckedChanged(object sender, EventArgs e)
        {
            groupBoxTo.Enabled = cbEmail.Checked;
        }

        private void ButtonSendTestEmailClick(object sender, EventArgs e)
        {
            try
            {
                Mail.Send(tbGmailUserName.Text, tbGmailUserPass.Text, tbMailRecipient.Text, "test", "test");
                MessageBox.Show("Mail was sent", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email, error: " + ex.Message, "Result");
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://support.google.com/calendar/bin/answer.py?hl=en&answer=45351");
        }

        private void btnSendSMS_Click(object sender, EventArgs e)
        {
            try
            {
                SMS.AddMeetingNow(tbGmailUserName.Text, tbGmailUserPass.Text, "test");
                MessageBox.Show("Appointment has been created.", "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create appointment, error: " + ex.Message, "Result");
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFilePath.Text = openFileDialog1.FileName;
            }
        }

    }
}
