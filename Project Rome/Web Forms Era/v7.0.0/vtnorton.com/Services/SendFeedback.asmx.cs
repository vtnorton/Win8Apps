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
        private static string Start = "<body><style>body{font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif !important;font-size:12px}h1{font-size:33px;font-weight:300;color:#2572EB}#body{border-top:1px solid #2572EB;margin:10px 0;padding-top:10px}#footer{width:100%;border-top:1px solid #ddd;padding:5px 0;line-height:17px;color:#3e3e3e}#footer a{color:#2572EB !important}#footer p{font-weight:300;text-align:center}.logo{float:left;margin-top:15px}table{color:#3e3e3e;float:right;margin-top:20px;}table td tr{padding:0; margin:0}table td:first-of-type{color:#9a9a9a;float:right}table td:last-of-type{padding-left:7px}#footer-inner{width:290px;margin:auto}</style><h1>Feedback</h1><div id='body'>";
        private static string End = "</div><div id='footer'><p>Você está recebendo este email porque você entrou em contato com Vítor Norton.<br/>Este email foi enviado por um endereço não monitorado. Não responda esta mensagem. Use os links embutidos no e-mail para obter mais informações.<br/>Respeito a sua privacidade, e em termos de transparência encaminhei à você as mesmas informações que foram compartilhadas comigo.</p><div id='footer-inner'><table><tr><td>Facebook: </td><td><a href='http://fb.com/vitor.norton'>Vítor Norton</a></td></tr><tr><td>Twitter: </td><td><a href='https://www.twitter.com/vt_norton'>@vt_norton</a></td></tr><tr><td>Instagram: </td><td><a href='https://www.instagram.com/vt_norton'>@vt_norton</a></td></tr><tr><td>Skype: </td><td>vtnorton</td></tr><tr><td>Site: </td><td><a href='http://vtnorton.com'>vtnorton.com</a></td></tr></table><div class='logo'><img src='http://www.vtnorton.com/images/logos/logo.vtnorton.email.png'/></div><div style='clear:both'></div></div></div></body>";
        [WebMethod]
        public bool SendFeedbackMenssage(string xMenssage, string xMail, string xSubject)
        {
            SmtpClient Client = new SmtpClient();
            MailMessage Message = new MailMessage();
            MailAddress replyTo = new MailAddress(xMail);
            try
            {
                Client.Host = "smtp.gmail.com";
                Client.Port = 587;
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential("jade@vtnorton.com", "");
                Client.EnableSsl = true;
                Message.IsBodyHtml = true;
                Message.ReplyTo = replyTo;
                Message.Subject = "[Quebec feedback]: " + xSubject;
                Message.Body = string.Concat(Start + "Who send the feedback: " + xMail + " <br/>This is the feedback sent by Project Quebec: " + xMenssage + End);
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
        public bool SendFeedbackMenssage(string xProject, string xMenssage, string xMail, string xSubject)
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
            Message.ReplyTo = replyTo;
            Message.Subject = "[" + xProject + " feedback]: " + xSubject;
            Message.Body = string.Concat(Start + "Who send the feedback: " + xMail + " <br/>This is the feedback sent by Project " + xProject + ": <br/>" + xMenssage + End);
            Message.From = new MailAddress("contato@vtnorton.com");
            Message.To.Add(new MailAddress("contato@vtnorton.com"));
            Client.Send(Message);
            return true;
        }
    }
}
