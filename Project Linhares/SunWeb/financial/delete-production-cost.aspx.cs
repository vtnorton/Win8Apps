using SunCore.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SunWeb.financial
{
    public partial class delete_production_cost : System.Web.UI.Page
    {
        Delete deleteProductionCost = new Delete();
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProductionCost.DeleteProductionCost(Id);
            Response.Redirect("/financial/delete-production-cost.aspx");
        }
    }
}