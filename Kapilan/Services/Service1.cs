using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Services
{
    public partial class Service1 : ServiceBase
    {
        private System.Timers.Timer timer = new System.Timers.Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
            timer.Interval = 5000; // 5 seconds (MilliSeconds)
            timer.Enabled = true;
            SendEmail();
            EventLog.WriteEntry("Daily Reporting service started", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            timer.Stop();
            EventLog.WriteEntry("Daily Reporting service stopped", EventLogEntryType.Information);
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                Thread emailThread = new Thread(SendEmail);
                emailThread.Start();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry($"Error starting email thread: {ex.Message}", EventLogEntryType.Error);
            }
        }

        private void SendEmail()
        {
            try
            {
                string senderEmail = "dharunvenkat2020@gmail.com";
                string receiverEmail = "kabilankabilan784@gmail.com";
                string subject = "Test Email";
                string body = "This is a test email sent using threads in C#.";

                using (MailMessage mail = new MailMessage(senderEmail, receiverEmail, subject, body))
                {
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("dharunvenkat2020@gmail.com", "ujkk fzys pfhs korp");

                        client.Send(mail);
                    }
                }

                EventLog.WriteEntry("Email sent successfully.", EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry($"Error sending email: {ex.Message}", EventLogEntryType.Error);
            }
        }
    }
}