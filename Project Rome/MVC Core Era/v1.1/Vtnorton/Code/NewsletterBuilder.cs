using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using Vtnorton.Model;

namespace Vtnorton.Code
{
    public class NewsletterBuilder
    {
        public static void Insert(Emails email, IHostingEnvironment env)
        {
            string listURI = WhatList(email.ListID);
            var file = Path.Combine(env.WebRootPath, "emails/" + listURI);

            string filecontent = File.ReadAllText(file);

            File.WriteAllText(file, filecontent + DateTime.Now + "," + email.Email + "," + email?.FirstName + "," + email?.LastName +
                "," + email?.TwitterProfile + "," + email?.FacebookProfile + "," + email?.LikedingProfile + ","
                 + email?.Observation + ";\n\n\r<br/>");
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
