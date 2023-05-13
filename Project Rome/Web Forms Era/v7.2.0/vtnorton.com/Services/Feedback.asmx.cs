using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using System.Web.Services;
using vtnCore.Classes;
using vtnCore.Methods;
using vtnCore.Repository;
using vtnCore.Stuff;

namespace VTNORTON.Services
{
    /// <summary>
    /// Summary description for Feedback
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Feedback : WebService
    {
        [WebMethod]
        public void SendFeedbackEmail(string xProject, string xMenssage, string xMail, string xSubject)
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
            Message.Subject = "[" + xProject + " feedback]: " + xSubject;
            Message.Body = string.Concat("Who send the feedback: <<a href='mailto:"+xMail+"'>" + xMail + "</a> <br/>This is the feedback sent by Project " + xProject + ": <br/>" + xMenssage);
            Message.ReplyToList.Add(new MailAddress(xMail));
            Message.From = new MailAddress("contato@vtnorton.com", "Vitor Norton");
            Message.To.Add(new MailAddress("contato@vtnorton.com", "Vitor Norton"));
            Client.Send(Message);

            InsertEmail.Insert(xMail, EmailLists.Formula);
        }
    }
}
