using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using Vtnorton.Model;

namespace Vtnorton.Code
{
    public class NewsletterBuilder
    {
        public async System.Threading.Tasks.Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Joe Bloggs", "jbloggs@example.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (var client = new SmtpClient())
            {
                client.LocalDomain = "some.domain.com";
                await client.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }
        public static void Insert(Emails email, IHostingEnvironment env)
        {
            string listURI = WhatList(email.ListID);
            var file = Path.Combine(env.WebRootPath, "emails/" + listURI);

            string filecontent = File.ReadAllText(file);

            File.WriteAllText(file, filecontent + DateTime.Now+","+email.Email+","+email?.FirstName+","+ email?.LastName +
                "," + email?.TwitterProfile + "," + email?.FacebookProfile + "," + email?.LikedingProfile + ","
                 + email?.Observation + ";\n");
        }


        public static string WhatList(int idList)
        {
            switch (idList)
            {
                case 1:
                    return @"main.txt";
                case 2:
                    return @"onenote.txt";
                case 3:
                    return @"formula.txt";
                case 4:
                    return @"truedarkmode.txt";
                case 5:
                    return @"palestras.txt";
                case 6:
                    return @"devnasnuvens.txt";
                default:
                    return @"unknow.txt";
            }
        }
    }
}
