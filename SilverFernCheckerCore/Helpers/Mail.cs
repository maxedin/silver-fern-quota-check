using System.Net;
using System.Net.Mail;

namespace SilverFernCheckerCore.Helpers
{
    public class Mail
    {
        public static void Send(string username, string password, string to, string subject, string body)
        {
            var credential = new NetworkCredential(username, password);
            var mail = new MailMessage();

            mail.To.Add(to);
            mail.Bcc.Add("silver.fern.bot@gmail.com");//just for statistic
            mail.Subject = "[AUTO] " + subject;
            mail.From = new MailAddress(username);
            mail.IsBodyHtml = true;
            mail.Body = body;

            var smtp = new SmtpClient("smtp.gmail.com")
                           {UseDefaultCredentials = false, EnableSsl = true, Credentials = credential, Port = 587};
            smtp.Send(mail);
        }

        public static void Send(string subject, string body)
        {
            var settings = new SilverFernCheckerCore.Settings.Settings();
            Mail.Send(settings.GmailUserName, settings.GmailUserPassword, settings.MailRecipient, subject, body);
        }
    }
}
