using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.agronomy
{
    public partial class agronomy_dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readCoffee = new Read();
            if (!IsPostBack)
            {
                //rptCoffee.DataSource = readCoffee.Farm(IdUser);
                rptCoffee.DataBind();

                if (rptCoffee.Items.Count == 0)
                {
                    //btnLoadMore.Visible = false;
                    lblErro.Text = "<div class='about-content text-center'><p><br/>Não foi encontrado nenhuma plantação de café.</p></div>";
                }
            }
        }
    }
}