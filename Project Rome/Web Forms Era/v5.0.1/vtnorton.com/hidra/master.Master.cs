using Core.Shared;
using System;

namespace VTNORTON.hidra
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSocialIcons.Text = "<ul><li><a href='" + SharedInformation.URLFacebook + "'><i class='fa fa-facebook'></i></a></li><li><a href='" + SharedInformation.URLTwitter + "'><i class='fa fa-twitter'></i></a></li><li><a href='" + SharedInformation.URLInstagram + "'><i class='fa fa-instagram'></i></a></li><li><a href='" + SharedInformation.URLGitHub + "'><i class='fa fa-github'></i></a></li><li><a href='" + SharedInformation.URLYoutube + "'><i class='fa fa-youtube'></i></a></li></ul>";
        }
    }
}