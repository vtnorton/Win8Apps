using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using AllVtnorton;

namespace HidraOnline.webOS
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Information.Hidra;
        }

        protected void btnLogin_Click(object sender, EventArgs e){
        }
    }
}