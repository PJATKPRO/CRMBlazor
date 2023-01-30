using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Infrastructure.Services.Mail
{
    public static class MailSender
    {
        public static string Send(string target, string subject, string body)
        {
            MailMessage mm = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            mm.From = new MailAddress("mistplix@gmail.com", "STMP service", System.Text.Encoding.UTF8);
            mm.To.Add(new MailAddress(target));
            mm.Subject = subject;
            mm.Body = body;

            mm.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("mistplix@gmail.com", "KupMiBoxa69");
            client.Timeout = 20000;
            try
            {
                client.Send(mm);
                return "Mail has been successfully sent!";
            }
            catch (Exception ex)
            {
                return "Fail Has error" + ex.Message;
            }
            finally
            {
                mm.Dispose();
            }
        }
    }
}
