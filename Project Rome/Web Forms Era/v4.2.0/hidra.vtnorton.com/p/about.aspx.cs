using AllVtnorton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p
{
    public partial class about : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLadon.Text = Information.Ladon;
            lblBuild.Text = Information.BuildInfo;
            lblHeartthrob.Text = Information.Heartthrob;
            lblHidra.Text = Information.Hidra;
            lblBuildFramework.Text = Information.BSharpFramework;
            lblHiraOnline.Text = Information.HidraOnline;
            lblOpenSearch.Text = Information.OpenSearch;
        }
    }
}