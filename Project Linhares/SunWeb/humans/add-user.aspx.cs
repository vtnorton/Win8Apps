using SunCore.Methods;
using SunCore.Repository;
using SunCore.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.humans
{
    public partial class add_user : System.Web.UI.Page
    {
        private int Id;
        EmployeeRepository repoEmployee = new EmployeeRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);

            
            lblName.Text = repoEmployee.RetornarID(Id).Name + " " + repoEmployee.RetornarID(Id).LastName;
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Create newUser = new Create();
            SmtpClient Cliente = new SmtpClient();
            MailMessage Message = new MailMessage();
            try
            {
                newUser.NewUser(1, Id, int.Parse(ddlAcessType.SelectedItem.Value), 1, "NO");
                Cliente.Host = EmailAccount.Host;
                Cliente.Port = EmailAccount.Port;
                Cliente.UseDefaultCredentials = EmailAccount.UseDefaultCredentials;
                Cliente.Credentials = new NetworkCredential(EmailAccount.Email, EmailAccount.Password);
                Cliente.EnableSsl = EmailAccount.EnableSsl;
                Message.IsBodyHtml = EmailAccount.IsBodyHtml;
                Message.Subject = "Queremos você como usuário no AgroAssistant";
                Message.Body = string.Concat("Acesse o sistema: <a href='http:agroassistant.azurewebsite.net/first-login.aspx?Id=" + Id + "'>Acesse o sistema aqui </a>");
                Message.From = new MailAddress(repoEmployee.RetornarID(Id).Email);
                Message.To.Add(new MailAddress(repoEmployee.RetornarID(Id).Email));
                Cliente.Send(Message);
                Page.MaintainScrollPositionOnPostBack = true;
                Response.Redirect("manage-employee.aspx?user=add");
            }
            catch (Exception ex)
            {

            }
        }
    }
}