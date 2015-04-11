using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class eMailer
    {
        public static string SendEmail(string toAddress, string subject, string body, bool isHTML)
        {
            string result = "Message Sent Successfully..!!";
            string senderID = "clts-notification@tavisca.com";// use sender's email id here..
            const string senderPassword = "test123!@#"; // sender password here...
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server address here...
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,
                };
                MailMessage message = new MailMessage(senderID, toAddress, subject, body);
                message.IsBodyHtml = isHTML;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                result = "Error sending email.!!!\n";
                Logger.Error(result + ex.Message);
            }
            Logger.Info(result);
            return result;
        }
    }
}
