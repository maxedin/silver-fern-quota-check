using System;
using SilverFernCheckerCore.Helpers;

namespace SilverFernCheckerCore.Settings
{
    public class Settings
    {
        private readonly RegistrySettings _settings;
        public Settings()
        {
            _settings = new RegistrySettings("HKEY_CURRENT_USER\\Software\\"+"SilvernFernChecker"); 
        }

        public bool SavePassword
        {
            get { return _settings.GetValue("SavePassword", false); }
            set { _settings.SetValue("SavePassword",value); }
        }

        public string WebSiteLogin
        {
            get { return _settings.GetValue("WebSiteLogin", ""); }
            set { _settings.SetValue("WebSiteLogin", value); }
        }

        public string WebSitePass
        {
            get { return PasswordCrypter.UnprotectPassword(_settings.GetValue("WebSitePass", "")); }
            set { _settings.SetValue("WebSitePass", PasswordCrypter.ProtectPassword(value)); }
        }

        public string WebSiteLoginURI
        {
            get { return _settings.GetValue("WebSiteLoginURI", @"https://www.immigration.govt.nz/secure/status.htm"); }
            set { _settings.SetValue("WebSiteLoginURI", value); }
        }

        public string WebSiteSuccessLoginPageURI
        {
            get { return _settings.GetValue("WebSiteSuccessLoginPageURI", @"http://www.immigration.govt.nz/migrant/default.htm"); }
            set { _settings.SetValue("WebSiteSuccessLoginPageURI", value); }
        }

        public string WebSiteQuotaURI
        {
            get { return _settings.GetValue("WebSiteQuotaURI", @"https://www.immigration.govt.nz/SilverFern/"); }
            set { _settings.SetValue("WebSiteQuotaURI", value); }
        }

        public string WebSiteLogoutURI
        {
            get { return _settings.GetValue("WebSiteLogoutURI", @"http://www.immigration.govt.nz/Registration/LogOut.aspx"); }
            set { _settings.SetValue("WebSiteLogoutURI", value); }
        }

        public string WebSiteQuotaPagePositiveString
        {
            get { return _settings.GetValue("WebSiteQuotaPagePositiveString", "There are currently places available for the Silver Fern Quota"); }
            set { _settings.SetValue("WebSiteQuotaPagePositiveString", value); }
        }

        //some keyword to understand that application form remains the same format.
        public string WebSiteQuotaPageNegotiveeString
        {
            //get { return _settings.GetValue("WebSiteQuotaPageNegotiveeString", "There are currently no places available for the Silver Fern Quota"); }
            get { return _settings.GetValue("WebSiteQuotaPageNegotiveeString", "There are currently no places available for the Silver Fern Quota"); }
            set { _settings.SetValue("WebSiteQuotaPageNegotiveeString", value); }
        }

        public string GmailUserName
        {
            get { return _settings.GetValue("GmailUserName", ""); }
            set { _settings.SetValue("GmailUserName", value); }
        }

        public string GmailUserPassword
        {
            get { return PasswordCrypter.UnprotectPassword(_settings.GetValue("GmailUserPassword", "")); }
            set { _settings.SetValue("GmailUserPassword", PasswordCrypter.ProtectPassword(value)); }
        }

        public string MailRecipient
        {
            get { return _settings.GetValue("MailRecipient", ""); }
            set { _settings.SetValue("MailRecipient", value); }
        }

        public bool NotificationViaEmail
        {
            get { return _settings.GetValue("NotificationViaEmail", false); }
            set { _settings.SetValue("NotificationViaEmail", value); }
        }

        public bool ErrorsViaEmail
        {
            get { return _settings.GetValue("ErrorsViaEmail", false); }
            set { _settings.SetValue("ErrorsViaEmail", value); }
        }


        public bool NotificationViaSms
        {
            get { return _settings.GetValue("NotificationViaSms", false); }
            set { _settings.SetValue("NotificationViaSms", value); }
        }

        public string CustomActionFilePath
        {
            get { return _settings.GetValue("CustomActionFilePath", ""); }
            set { _settings.SetValue("CustomActionFilePath", value); }
        }
    }
}
