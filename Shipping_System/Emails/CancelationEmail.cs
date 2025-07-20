using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Shipping_System.Forms.AdminLogin;

namespace Shipping_System.Emails
{
    public static class CancelationEmail
    {
        private const string SmtpAddress = "smtp.gmail.com";
        private const int PortNumber = 587;
        private const bool EnableSsl = true;
        private static readonly string EmailFrom = Session.email;
        private const string Password = "skjz odsp pexe ywxb"; // Use App Password for Gmail
        public static void SendCancelationEmail(string recipientEmail)
        {
            string subject = "Your Details Have Been Cancelled";
            string body = $@"Dear Customer,

Your job order have been unfortunately cancelled.

Our all the transportation services are currently unavailable.

Please try again later or contact our customer service for further assistance.

appologize for any inconvenience this may have caused.

Canceletion Date: {DateTime.Now:dd/MM/yyyy}

Thank you for using our service.

Best regards,
Customer Service Team";

            SendEmail(recipientEmail, subject, body);
        }

        private static void SendEmail(string recipientEmail, string subject, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(EmailFrom);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient(SmtpAddress, PortNumber))
                {
                    smtp.Credentials = new NetworkCredential(EmailFrom, Password);
                    smtp.EnableSsl = EnableSsl;

                    try
                    {
                        smtp.Send(mail);
                        // You might want to log this success
                    }
                    catch (Exception ex)
                    {
                        // Handle or log the exception
                        throw new Exception($"Email sending failed: {ex.Message}");
                    }
                }
            }
        }
    }
}
