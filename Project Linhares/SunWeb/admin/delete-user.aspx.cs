using SunCore.Classes;
using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.admin
{
    public partial class delete_user : System.Web.UI.Page
    {
        Delete deleteUser = new Delete();
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);

            UserRepository repoUser = new UserRepository();

            lblUser.Text = repoUser.RetornarID(Id).Name + " " + repoUser.RetornarID(Id).LastName;
            
             
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deleteUser.DeleteUser(Id);
            Response.Redirect("/admin/manage-users.aspx");
        }
    }
}