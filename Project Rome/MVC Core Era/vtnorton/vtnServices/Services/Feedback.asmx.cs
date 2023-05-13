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
    public class Feedback : WebService
    {

        [WebMethod]
        public void SendFeedbackEmail(string xProject, string xMenssage, string xMail, string xSubject)
        {
            Message toSend = new Message();

            toSend.ListID = 3;
            toSend.Project = xProject;
            toSend.Title = xSubject;
            toSend.Email = xMail.Trim().ToLower();
            toSend.Content = xMenssage.Trim();

            SendEmail.SendFeedbackEmail(toSend);
        }
    }
}
