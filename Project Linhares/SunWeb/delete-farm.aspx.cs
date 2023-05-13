using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb
{
    public partial class delete_farm : System.Web.UI.Page
    {
        Delete deleteFarm = new Delete();
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);

            FarmRepository repoUser = new FarmRepository();

            lblUser.Text = repoUser.RetornarID(Id).Name;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deleteFarm.DeleteUser(Id);
            Response.Redirect("/dashboard.aspx");
        }
    }
}