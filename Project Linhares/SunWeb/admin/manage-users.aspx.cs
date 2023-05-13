using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.admin
{
    public partial class manage_users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readUser = new Read();
            if (!IsPostBack)
            {
                rptUsers.DataSource = readUser.User();
                rptUsers.DataBind();

                if (rptUsers.Items.Count == 0)
                {
                    //btnLoadMore.Visible = false;
                    lblErro.Text = "<div class='about-content text-center'><p><br/>Não foi encontrado nenhum usuário no momento. O que é estranho, então deve ter algo errado! </p></div>";
                }
            }
        }
    }
}