using System.ComponentModel;
using System.Web.Services;
using System.Web.Script.Services;
using vtnServices.Code;
using vtnServices.Models;

namespace vtnServices.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Formula : WebService
    {
        [WebMethod]
        public void SendKey(string urlKey, string mail)
        {
            Message toSend = new Message();
            toSend.Title = "Você ganhou uma chave do Formula - Universal Code Editor";
            toSend.Email = mail;
            toSend.Content = string.Concat("Para ativar a sua licença do Formula, entre com a sua conta da Microsoft no seguinte link <a href='" + urlKey + "'>" + urlKey + "</a> <br/>Vítor Norton<br/>contato@vtnorton.com<br/>Windows Insider MVP");

            SendEmail.SendEmailOnly(toSend, mail, mail);
        }
    }
}
