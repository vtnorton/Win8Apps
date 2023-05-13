using Ladon.Methods;
using Ladon.Repository;
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
            int NumberOfPost = 10;
            int NumberOfWidget = 5;
            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            try
            {
                Repeater1.DataSource = readPost.Post(true, NumberOfPost, StartWith,1);
                Repeater1.DataBind();
            }
            catch(Exception E)
            {
                Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página de início do blog. Dados: StartWith = " + StartWith + ". Erro: " + E.Message, "vtnorton.com");
                Response.Redirect("/erro/000");
            }

            Read widget = new Read();
            Repeater2.DataSource = widget.Post(true, NumberOfWidget, 0,1);
            Repeater2.DataBind();

            if (StartWith != 0)
            {
                lblLessPost.Text = "<a href='/blog/?sw=" + (StartWith - NumberOfPost) + "'>Posts mais recentes</a>";
            }
            if (!(Repeater2.Items.Count % NumberOfPost == 0))
            {
                lblMorePost.Text = "<a href='/blog/?sw=" + (StartWith + NumberOfPost) + "'>Posts mais antigos</a>";
            }
        }
    }
}