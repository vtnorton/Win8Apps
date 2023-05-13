using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Services;

namespace VTNORTON.Services
{
    [WebService(Namespace = "http://vtnorton.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SendFeedback : System.Web.Services.WebService
    {

        [WebMethod]
        public bool SendFeedbackMenssage(string xMenssage, string xMail, string xSubject)
        {
            SmtpClient Client = new SmtpClient();
            MailMessage Message = new MailMessage();
            try
            {
                Client.Host = "smtp.gmail.com";
                Client.Port = 587;
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential("jade@vtnorton.com", "");
                Client.EnableSsl = true;
                Message.Subject = "[Quebec feedback]: " + xSubject;
                Message.Body = string.Concat("Who send the feedback: " + xMail + " \nThis is the feedback sent by Project Quebec: " + xMenssage);
                Message.From = new MailAddress("contato@vtnorton.com");
                Message.To.Add(new MailAddress("contato@vtnorton.com"));
                Client.Send(Message);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
    }
}
