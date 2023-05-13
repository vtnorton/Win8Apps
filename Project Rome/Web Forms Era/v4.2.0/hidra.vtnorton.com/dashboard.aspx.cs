using AllVtnorton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLadon.Text = Information.Ladon;
            lblBuild.Text = Information.BuildInfo;
            lblHeartthrob.Text = Information.Heartthrob;
            lblHidra.Text = Information.Hidra;
            lblBuildFramework.Text = Information.BSharpFramework;
            lblSite.Text = Information.Vtnorton;
            lblHiraOnline.Text = Information.HidraOnline;
            lblOpenSearch.Text = Information.OpenSearch;
            try
            {

            }
            catch (Exception ex)
            {
                Response.Redirect("/webOS/rsod.aspx?Source="+ ex.Source+"&Message="+ex.Message+"&InnerException"+ex.InnerException+"&HResult"+ex.HResult);
            }
        }
    }
}