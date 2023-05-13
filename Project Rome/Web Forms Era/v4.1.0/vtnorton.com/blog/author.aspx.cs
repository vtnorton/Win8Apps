using Ladon.Methods;
using Ladon.Repository;
using System;

namespace VTNORTON.blog
{
    public partial class author : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["id"]);
            int StartWith;
            if (Request.QueryString["sw"] != null)
            {
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            }
            else
            {
                StartWith = 0;
            }

            Read readPost = new Read();
            AuthorRepository repoAuthor = new AuthorRepository();
            Read widget = new Read();
            Create Bug = new Create();

            try
            {
                Repeater2.DataSource = widget.Post(true, 5, 0);
                Repeater2.DataBind();
            }
            catch
            {
                Bug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página do author. Id de entrada: " + Id + ".", "vtnorton.com");
            }

            String AuthorName = repoAuthor.RetornarID(Id).Name;

            lblAuthorName.Text = AuthorName;
            lblAuthorNameSubMenu.Text = "<a class='on' href='/author.aspx?id="+ Id +"'>"+AuthorName+"</a>";
            lblAuthorJob.Text = repoAuthor.RetornarID(Id).Job;
            lblAuthorDescription.Text = repoAuthor.RetornarID(Id).Description;
            lblAuthorProfileImage.Text = "<img src='" + repoAuthor.RetornarID(Id).URLProfile + "' />";
            lblAuthorCover.Text = "<div class='author' style='background: url(" + repoAuthor.RetornarID(Id).URLCover + ") no-repeat center center fixed; background-size: cover;'>";

            try
            {
                Repeater1.DataSource = readPost.Post(true, 10, StartWith);
                Repeater1.DataBind();
            }
            catch
            {
                lblErro.Text = "Erro ao carregar posts desse autor. Eu provavelmente já estou providenciando um concerto para isso, mas por favor, entre em contato comigo.";
                Bug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página do author. Id de entrada: " + Id + ".", "vtnorton.com");
            }
            

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