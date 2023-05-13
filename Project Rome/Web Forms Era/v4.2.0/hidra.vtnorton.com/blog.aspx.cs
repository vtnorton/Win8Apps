using Ladon.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline
{
    public partial class blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readPost = new Read();

            rptLastPost.DataSource = readPost.Post(true, 3, 0);
            rptLastPost.DataBind();
        }
    }
}