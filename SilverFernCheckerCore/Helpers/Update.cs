using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SilverFernCheckerCore.Helpers
{
    public static class UpdateClass
    {
        private const string VersionPage = "http://code.google.com/p/silver-fern-quota-check/wiki/version";
        private const string DownloadPage = "http://code.google.com/p/silver-fern-quota-check/downloads/list";
           
        public static bool IsNewVersionAvailible()
        {
            try
            {
                var webBrowser = new WebBrowser() {ScriptErrorsSuppressed = true};
                webBrowser.Navigate(VersionPage);
                while (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }

                var versionFromWeb = FindVersionCode(webBrowser.DocumentText);
                var versionCurrent = GetApplicationVersion();

                if (versionCurrent < versionFromWeb)
                    return true;
            }
            catch(Exception)
            {
                //suppress errors during update
            }
            return false;
        }

        public static void GotoDownloadPage()
        {
            Process.Start(DownloadPage);
        }

        private static Version FindVersionCode(string webText)
        {
            const string pattern = @"(?<=\[)(?<Major>\d*)\.(?<Minor>\d*)\.(?<Build>\d*)\.(?<Revision>\d*)(?=\])";
            var versionString = Regex.Match(webText, pattern).Value;
            var version = Version.Parse(versionString);
            return version;
        }

        public static Version GetApplicationVersion()
        {
            return System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
        }
    }
}
