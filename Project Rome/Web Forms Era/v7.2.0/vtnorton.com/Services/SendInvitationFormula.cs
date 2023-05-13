using System.Net;
using System.Net.Mail;

namespace VTNORTON.Services
{
    public class SendInvitationFormula
    {
        public void SendEmailPT(string KeyURL, string xMail)
        {
            MailAddress replyTo = new MailAddress(xMail);
            SmtpClient Client = new SmtpClient();
            MailMessage Message = new MailMessage();
            Client.Host = "smtp.gmail.com";
            Client.Port = 587;
            Client.UseDefaultCredentials = false;
            Client.Credentials = new NetworkCredential("jade@vtnorton.com", "");
            Client.EnableSsl = true;
            Message.IsBodyHtml = true;
            Message.Subject = "Você ganhou uma chave do Formula - Universal Code Editor";
            Message.Body = string.Concat("Para ativar a sua licença do Formula, entre com a sua conta da Microsoft no seguinte link <a href='"+ KeyURL+ "'>" + KeyURL + "</a> <br/>Vítor Norton<br/>contato@vtnorton.com<br/>Windows Insider MVP");
            Message.ReplyToList.Add(new MailAddress(xMail));
            Message.From = new MailAddress("contato@vtnorton.com", "Vitor Norton");
            Message.To.Add(new MailAddress("contato@vtnorton.com", "Vitor Norton"));
            Client.Send(Message);
        }
    }
}