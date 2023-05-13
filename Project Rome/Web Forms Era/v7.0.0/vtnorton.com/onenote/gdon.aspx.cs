using System;
using VTNORTON.Core;

namespace VTNORTON.onenote
{
    public partial class gdon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SQLCommands sqlCommands = new SQLCommands();
                sqlCommands.SQLCommand("UPDATE tbl_ebooks SET Downloads = Downloads + 1 WHERE Id = 1");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Response.Redirect("Guia-definitivo-para-o-OneNote-v1.0.pdf");
            }
        }
    }
}