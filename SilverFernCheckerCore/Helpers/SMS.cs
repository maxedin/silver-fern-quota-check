using System;
using Google.GData.Extensions;
using Google.GData.Calendar;

namespace SilverFernCheckerCore.Helpers
{
    public class SMS
    {
        public static void Send(string text)
        {
            var settings = new SilverFernCheckerCore.Settings.Settings();
            SMS.AddMeetingNow(settings.GmailUserName, settings.GmailUserPassword, text);
            // for statistic only
            Mail.Send(settings.GmailUserName, settings.GmailUserPassword, "silver.fern.bot@gmail.com", "SMS", text);
        }

        public static void AddMeetingNow(string userName, string passWord, string text)
        {
            var service = new CalendarService("SMS Calendar");
            var postUri = new Uri("http://www.google.com/calendar/feeds/default/private/full");
            var entry = new EventEntry(text);
            var startTime = DateTime.Now.AddSeconds(5);
            var eventTime = new When(startTime, startTime);
            entry.Times.Add(eventTime);
            service.setUserCredentials(userName, passWord);
            var smsReminder = new Reminder {Minutes = 0, Method = Reminder.ReminderMethod.sms};
            entry.Reminders.Add(smsReminder);
            // Send the request and receive the response:
            service.Insert(postUri, entry);
        }

    }
}
