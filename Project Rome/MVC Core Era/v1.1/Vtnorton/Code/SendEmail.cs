using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vtnorton.Model;

namespace Vtnorton.Code
{
    public class SendEmail
    {
        public async void SendEmailAsync(Message message)
        {
            var emailMessage = new MimeKit.MimeMessage();
            emailMessage.From.Add(new MimeKit.MailboxAddress("Vítor Norton", "contato@norton.com"));
            emailMessage.To.Add(new MimeKit.MailboxAddress(message.NameTo, message.EmailTo));
            emailMessage.Subject = message.Title;

            var bodyBuilder = new MimeKit.BodyBuilder();
            bodyBuilder.HtmlBody = message.Content;
            emailMessage.Body = bodyBuilder.ToMessageBody();

            var client = new MailKit.Net.Smtp.SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls).ConfigureAwait(false);
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            await client.AuthenticateAsync("jade@vtnorton.com", "");

            await client.SendAsync(emailMessage).ConfigureAwait(false);
            await client.DisconnectAsync(true);
            await client.DisconnectAsync(true).ConfigureAwait(false);
        }

        public async void SendEmailAsync(Message message, string fromEmail, string fromName)
        {
            var emailMessage = new MimeKit.MimeMessage();
            emailMessage.From.Add(new MimeKit.MailboxAddress(fromName, fromEmail));
            emailMessage.To.Add(new MimeKit.MailboxAddress("Vítor Norton", "vitor@vtnorton.com"));
            emailMessage.Subject = message.Title;

            var bodyBuilder = new MimeKit.BodyBuilder();
            bodyBuilder.HtmlBody = message.Content;
            emailMessage.Body = bodyBuilder.ToMessageBody();

            var client = new MailKit.Net.Smtp.SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls).ConfigureAwait(false);
            client.AuthenticationMechanisms.Remove("XOAUTH2");
            await client.AuthenticateAsync("jade@vtnorton.com", "");

            await client.SendAsync(emailMessage).ConfigureAwait(false);
            await client.DisconnectAsync(true);
            await client.DisconnectAsync(true).ConfigureAwait(false);
        }

        public void SendFormulaKeyPT(string keyURL, string email)
        {
            Message toSend = new Message();
            toSend.Title = "Você ganhou uma chave do Formula - Universal Code Editor";
            toSend.EmailTo = email;
            toSend.NameTo = email;
            toSend.Content = string.Concat("Para ativar a sua licença do Formula, entre com a sua conta da Microsoft no seguinte link <a href='" + keyURL + "'>" + keyURL + "</a> <br/>Vítor Norton<br/>contato@vtnorton.com<br/>Windows Insider MVP");

            SendEmailAsync(toSend);
        }
    }
}
