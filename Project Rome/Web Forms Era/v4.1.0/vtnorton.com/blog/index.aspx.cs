using Ladon.Methods;
using System;
using System.Web;
using System.Web.UI;

namespace VTNORTON.blog
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StartWith;
            Create Bug = new Create();
            Read readPost = new Read();
            if (Request.QueryString["sw"] != null)
            {
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            }
            else
            {
                StartWith = 0;
            }

            try
            {
                
                Repeater1.DataSource = readPost.Post(true, 10, StartWith);
                Repeater1.DataBind();
            }
            catch
            {
                Bug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página de início do blog. Dados: StartWith = " + StartWith + ".", "vtnorton.com");
                Response.Redirect("/erro/000");
            }

            Read widget = new Read();
            Repeater2.DataSource = widget.Post(true, 5, 0);
            Repeater2.DataBind();

            if (StartWith != 0)
            {
                lblLessPost.Text = "<a href='/blog/?sw=" + (StartWith - 10) + "'>Posts mais recentes</a>";
            }
            if (Repeater1.Items.Count >= 10)
            {
                lblMorePost.Text = "<a href='/blog/?sw=" + (StartWith + 10) + "'>Posts mais antigos</a>";
            }
        }
    }
}