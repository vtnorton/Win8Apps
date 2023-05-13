using System;
using vtnCore;
using vtnCore.Methods;

namespace VTNORTON.onenote
{
    public partial class gdon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                new SqlCommands().SQLCommand("UPDATE "+ TableNames.Ebooks+" SET Downloads = Downloads + 1 WHERE Id = 1");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Response.Redirect("Guia-definitivo-para-o-OneNote-v1.0.pdf");
            }
        }
    }
}