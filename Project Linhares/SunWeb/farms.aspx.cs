using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb
{
    public partial class farms : System.Web.UI.Page
    {
        private int IdUser = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readFarm = new Read();
            if (!IsPostBack)
            {
                rptFarms.DataSource = readFarm.Farm(IdUser);
                rptFarms.DataBind();

                if (rptFarms.Items.Count == 0)
                {
                    //btnLoadMore.Visible = false;
                    lblErro.Text = "<div class='about-content text-center'><p><br/>Não foi encontrado nenhuma fazenda no momento. O que é estranho, então deve ter algo errado! </p></div>";
                }
            }
        }
    }
}