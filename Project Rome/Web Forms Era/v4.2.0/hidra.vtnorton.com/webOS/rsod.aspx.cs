using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.webOS
{
    public partial class rsod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Source = Request.QueryString["Source"];
            String Message = Request.QueryString["Message"];
            String InnerException = Request.QueryString["InnerException"];
            String HResult = Request.QueryString["HResult"];

            lblErro.Text = "<h3>Source: " + Source + "</h3><h4>InnerExecption: " + InnerException + "</h4><br />" + Message + "</br>" + HResult;

        }
    }
}