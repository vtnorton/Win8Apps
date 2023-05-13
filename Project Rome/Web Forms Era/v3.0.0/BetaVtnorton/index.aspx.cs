using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BetaVtnorton
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random randNum = new Random();
            lblEasterEgg.Text = "<style>body{background: url(/img/" + randNum.Next(1, 22).ToString() + ".jpg) no-repeat; background-position:top left; background-size:cover}</style>";
        }
    }
}