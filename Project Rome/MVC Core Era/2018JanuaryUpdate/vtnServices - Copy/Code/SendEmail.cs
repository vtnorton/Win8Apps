using System.Net;
using System.Net.Mail;
using vtnServices.Models;

namespace vtnServices.Code
{
    public class SendEmail
    {
        public void SendFeedbackEmail(Message xMenssage)
        {
            xMenssage.ListID = 3;

            //InsertMail.Insert(mail);

            MailAddress replyTo = new MailAddress(xMenssage.Email.Trim().ToLower());
            SmtpClient Client = new SmtpClient();
            MailMessage Message = new MailMessage();

            Client.Host = "smtp.gmail.com";
            Client.Port = 587;
            Client.UseDefaultCredentials = false;
            Client.Credentials = new NetworkCredential("jade@vtnorton.com", "");
            Client.EnableSsl = true;

            Message.IsBodyHtml = true;
            Message.Subject = "[" + xMenssage.Project + " feedback]: " + xMenssage.Title;
            Message.Body = string.Concat("This feedback was sent by: <a href='mailto:" + xMenssage.Email + "'>" + xMenssage.Email + "</a> <br/>This is the feedback sent by " + xMenssage.Project + ": <br/>" + xMenssage.Content + "<br/><br/><br/>vtnService: " + Information.Version);
            Message.ReplyToList.Add(new MailAddress(xMenssage.Email));
            Message.From = new MailAddress("contato@vtnorton.com", "Vitor Norton");
            Message.To.Add(new MailAddress("contato@vtnorton.com", "Vitor Norton"));

            Client.Send(Message);   
        }
    }
}