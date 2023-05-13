using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.financial
{
    public partial class manage_production_cost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readProductionCost = new Read();
            if (!IsPostBack)
            {
                rptProductionCost.DataSource = readProductionCost.ProductionCost(1);
                rptProductionCost.DataBind();

                if (rptProductionCost.Items.Count == 0)
                {
                    //btnLoadMore.Visible = false;
                    lblErro.Text = "<div class='about-content text-center'><p><br/>Não foi encontrado nenhum relatório no momento. </p></div>";
                }
            }
        }
    }
}