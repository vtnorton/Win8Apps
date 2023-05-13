using System;

namespace VTNORTON
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String SearchQuery = Request.QueryString["q"];
            lblSearchQuery.Text = "Resultado para a pesquisa: " + SearchQuery?.ToString();
        }
    }
}