using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using SilverFernCheckerCore.Helpers;
using SilverFernCheckerCore.Settings;
using System.IO;

namespace SilverFernChecker
{
    public partial class MainForm : Form
    {
        private readonly Settings _settings = new Settings();
        private int _elapsedTimeInMinutes;

        #region Form behavior

        public MainForm()
        {
            InitializeComponent();
            // disable control to prevent manual clicking and navigating
            ((Control)webBrowser).Enabled = false;
            DisableWebBrowserClickSounds.Disable();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Hide();
            Text = Text + " (version: " + UpdateClass.GetApplicationVersion().ToString() + ")";
            var isNewVersionAvailible = UpdateClass.IsNewVersionAvailible();
            if (isNewVersionAvailible)
            {
                Notify(MessageType.Warning, "New version availible. Download new version from the website");
            }
        }

        private void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            //do not close application when press cross button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void TrayIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            Show();
        }

        private void ButtonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSettingsClick(object sender, EventArgs e)
        {
            var f = new SettingsForm();
            f.Show();
        }

        private void TrayIconBalloonTipClicked(object sender, EventArgs e)
        {
            Show();
        }

        private void ButtonResetClick(object sender, EventArgs e)
        {
            timerCheckingInterval.Stop();
            timerCheckingInterval.Interval = 100;
            timerCheckingInterval.Start();
        }

        private void ButtonDonateClick(object sender, EventArgs e)
        {
            Process.Start("http://code.google.com/p/silver-fern-quota-check/wiki/Donate");
        }

        private void ButtonFeedbackClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start("mailto:silver.fern.bot@gmail.com?subject=Feedback");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not find default mail application. Please send it manually to silver.fern.bot@gmail.com. Error: " + ex.Message, "Exception");
            }
        }

        private void ButtonProjectWebpage_Click(object sender, EventArgs e)
        {
            Process.Start("http://code.google.com/p/silver-fern-quota-check/");
        }

        #endregion

        private void AddToLog(string text)
        {
            //todo write history to log file, need to find  solution to solve problem with admin rights to access file
            if (listBoxLog.Items.Count > 100)
            {
                listBoxLog.Items.RemoveAt(0);
            }
            var dateAndMsg = string.Format("{0}: {1}", DateTime.Now.ToString(CultureInfo.InvariantCulture), text);
            listBoxLog.Items.Add(dateAndMsg);
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
        }

        private void SendEmail(string text)
        {
            try
            {
                Mail.Send(text + " Copy of the webpage\\message is in the body.", webBrowser.DocumentText);
                Notify(MessageType.Information, "Email was sent to " + _settings.MailRecipient);
            }
            catch (Exception ex)
            {
                Notify(MessageType.Error, "Failed to send email: " + ex.Message);
            }
        }

        private void SendSms(string text)
        {
            try
            {
                SMS.Send(text);
                Notify(MessageType.Information, "SMS was sent.");
            }
            catch (Exception ex)
            {
                Notify(MessageType.Error, "Failed to send sms, error: " + ex.Message);
            }
        }

        private void OpenFile(string path)
        {
            try
            {
                Process.Start(path);
                Notify(MessageType.Information, "Opened " + path);
            }
            catch (Exception ex)
            {
                Notify(MessageType.Error, "Failed to open " + path + " , error: " + ex.Message);
            }
        }

        private void Notify(MessageType type, string text)
        {
            switch (type)
            {
                case MessageType.Warning:
                    {
                        trayIcon.ShowBalloonTip(5000, "Silver Fern Checker", text, ToolTipIcon.Warning);
                        break;
                    }
                case MessageType.Success:
                    {
                        MessageBox.Show("Quota availible!", "Silver Fern Checker");
                        trayIcon.ShowBalloonTip(5000, "Silver Fern Checker", text, ToolTipIcon.Info);
                        if (_settings.NotificationViaEmail) SendEmail(text);
                        if (_settings.NotificationViaSms) SendSms(text);
                        if (!string.IsNullOrWhiteSpace(_settings.CustomActionFilePath))
                            OpenFile(_settings.CustomActionFilePath);
                        break;
                    }
                case MessageType.Error:
                    {
                        trayIcon.ShowBalloonTip(5000, "Silver Fern Checker", text, ToolTipIcon.Error);
                        if (_settings.NotificationViaEmail && _settings.ErrorsViaEmail) SendEmail(text);
                        break;
                    }
            }
            AddToLog(text);
        }

        private void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                if (webBrowser.DocumentText.Contains("Sorry, the website is not available at the moment.")
                    || e.Url.AbsoluteUri == "https://www.immigration.govt.nz/error.htm?aspxerrorpath=/Templates/Secure/Login.aspx"
                    || webBrowser.DocumentText.Contains("Эта программа не может отобразить эту веб-страницу"))
                {
                    Notify(MessageType.Information, "The website is not available at the moment.");
                    return;
                }
                if (e.Url.AbsoluteUri == _settings.WebSiteLoginURI)
                {
                    AutoLogin(webBrowser.Document);
                    return;
                }
                if (e.Url.AbsoluteUri == _settings.WebSiteSuccessLoginPageURI)
                {
                    webBrowser.Navigate(_settings.WebSiteQuotaURI);
                    Notify(MessageType.Information, "Navigating to silver fern quota page.");
                    return;
                }
                if (e.Url.AbsoluteUri == _settings.WebSiteQuotaURI)
                {
                    CheckQuota(webBrowser.DocumentText);
                    webBrowser.Navigate(_settings.WebSiteLogoutURI);
                    Notify(MessageType.Information, "Logging out.");
                    return;
                }
                if (e.Url.AbsoluteUri == "https://www.immigration.govt.nz/")
                {
                    Notify(MessageType.Information, "Logged out successfully.");
                    return;
                }
                if (webBrowser.DocumentText.Contains("You have entered an incorrect user name or password"))
                {
                    Notify(MessageType.Error, "You have entered an incorrect user name or password.");
                    return;
                }
                if (webBrowser.DocumentText.Contains("exceeded the maximum number of attempts"))
                {
                    Notify(MessageType.Error, "You can not Log in right now as you have exceeded the maximum number(3) of attempts, account locked for 8 hours");
                    return;
                }
                //otherwise error
                Notify(MessageType.Error, "Webpage doesn't look like we expected.");
            }
        }

        private void AutoLogin(HtmlDocument document)
        {
            try
            {
                HtmlElement element = null;
                //pass login
                element = document.GetElementById("OnlineServicesLoginStealth_VisaLoginControl_userNameTextBox");
                element.SetAttribute("value", _settings.WebSiteLogin);
                Notify(MessageType.Information, "Passing username.");
                //pass password
                element = document.GetElementById("OnlineServicesLoginStealth_VisaLoginControl_passwordTextBox");
                element.SetAttribute("value", _settings.WebSitePass);
                Notify(MessageType.Information, "Passing password.");
                //click login button
                element = document.GetElementById("OnlineServicesLoginStealth_VisaLoginControl_loginImageButton");
                element.InvokeMember("click");
                Notify(MessageType.Information, "Clicking login button.");
            }
            catch (Exception)
            {
                Notify(MessageType.Error, "Autologin error: unable to insert value - html element is missing");
            }
        }

        private void CheckQuota(string documentText)
        {
            if (documentText.Contains(_settings.WebSiteQuotaPageNegotiveeString))
            {
                Notify(MessageType.Information, "No places availible.");
            }
            else if (documentText.Contains(_settings.WebSiteQuotaPagePositiveString))
            {
                Notify(MessageType.Success, " Places availible! Hurry up!");
            }
            else
            {
                Notify(MessageType.Error, "Quota webpage doesn't look like we expected.  If the webpage has been modified you need to change keywords in application settings.");
            }
        }

        private void TimerCountdownTick(object sender, EventArgs e)
        {
            _elapsedTimeInMinutes--;
            ButtonReset.Text = string.Format("Next check in {0} min", _elapsedTimeInMinutes);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            var ticks = new Random();
            timerCheckingInterval.Interval = ticks.Next(1800000, 3600000);
            _elapsedTimeInMinutes = TimeSpan.FromMilliseconds(timerCheckingInterval.Interval).Minutes;
            ButtonReset.Text = string.Format("Next check in {0} min", _elapsedTimeInMinutes);

            if (string.IsNullOrWhiteSpace(_settings.WebSitePass) || string.IsNullOrWhiteSpace(_settings.WebSiteLogin))
            {
                Show();
                var f = new SettingsForm();
                if (f.ShowDialog() != DialogResult.OK)
                {
                    Notify(MessageType.Error, "Unable to start. Website login or password is missing.");
                    return;
                }
            }
            Notify(MessageType.Information, "-----start new check-----");
            Notify(MessageType.Information, "Loading login page.");
            webBrowser.Navigate(_settings.WebSiteLoginURI);
        }

    }
}
