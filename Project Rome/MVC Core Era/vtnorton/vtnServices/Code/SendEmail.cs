using System.Net;
using System.Net.Mail;
using vtnServices.Models;

namespace vtnServices.Code
{
    public class SendEmail
    {
        public static void SendFeedbackEmail(Message xMenssage)
        {
            xMenssage.ListID = 3;
            xMenssage.Title = "[" + xMenssage.Project + " feedback]: " + xMenssage.Title;
            xMenssage.Content = string.Concat("This feedback was sent by: <a href='mailto:" + xMenssage.Email + "'>" + xMenssage.Email + "</a> <br/>This is the feedback sent by " + xMenssage.Project + ": <br/>" + xMenssage.Content + "<br/><br/><br/>vtnService: " + Information.Version);
            SendEmailOnly(xMenssage, "contato@vtnorton.com", "Vítor Norton");

            //InsertMail.Insert(mail);
        }

        public static void SendEmailOnly(Message xMessage, string destinatario, string destinatarioName)
        {

            MailAddress replyTo = new MailAddress(xMessage.Email);
            SmtpClient Client = new SmtpClient();
            MailMessage Message = new MailMessage();
            Client.Host = "smtp.gmail.com";
            Client.Port = 587;
            Client.UseDefaultCredentials = false;
            Client.Credentials = new NetworkCredential("jade@vtnorton.com", "");
            Client.EnableSsl = true;
            Message.IsBodyHtml = true;
            Message.Subject = xMessage.Title;
            Message.Body = xMessage.Content;
            Message.ReplyToList.Add(new MailAddress(xMessage.Email));
            Message.From = new MailAddress(destinatario, destinatarioName);
            Message.To.Add(new MailAddress(destinatario, destinatarioName));
            Client.Send(Message);
        }
    }
}