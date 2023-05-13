using AllVtnorton;
using BSharp.Methods;
using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readCategory = new Read();
            PostRepository repoPost = new PostRepository();
            int IdLastPost = readCategory.PostLastId();
            String varBuild = Information.BuildInfo;
            String varHeartthrob = Information.Heartthrob;
            String varHidra = Information.Hidra;
            String varBuildFramework = Information.BSharpFramework;
            String varVtnorton = Information.Vtnorton;
            String varPostURL = "/blog/" + repoPost.RetornarID(IdLastPost).URL;

            rptCategoryBlog.DataSource = readCategory.Category();
            rptCategoryBlog.DataBind();


            lblPostFirstParagrahWidget.Text = repoPost.RetornarID(IdLastPost).FirstParagraph + "<br /><a href='" + varPostURL + "'> Leia mais </a>";
            lblPostTitleWidget.Text = "<a href='" + varPostURL + "'>" + repoPost.RetornarID(IdLastPost).Title + "</a>";
            lblPostImageWidget.Text = repoPost.RetornarID(IdLastPost).URLImage;
                
            lblSite3.Text = varVtnorton;

            lblHidra2.Text = varHidra;
            lblBuildFramework2.Text = varBuildFramework;
            lblSite2.Text = varVtnorton;

            lblLadon.Text = Information.Ladon;
            lblBuild.Text = varBuild;
            lblHeartthrob.Text = varHeartthrob;
            lblHidra.Text = varHidra;
            lblBuildFramework.Text = varBuildFramework;
            lblSite.Text = varVtnorton;
        }
    }
}