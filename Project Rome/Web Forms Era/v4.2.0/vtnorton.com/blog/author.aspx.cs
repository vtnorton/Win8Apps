using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Configuration;

namespace VTNORTON.blog
{
    public partial class author : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int NumberOfPost = 10;
            int NumberOfWidget = 5;

            int Id = Convert.ToInt32(Request.QueryString["id"]);
            
            int StartWith;
            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            Read readPost = new Read();
            AuthorRepository repoAuthor = new AuthorRepository();
            Read widget = new Read();
            Create Bug = new Create();

            try
            {
                Repeater2.DataSource = widget.Post(true, NumberOfWidget, 0,1);
                Repeater2.DataBind();
            }
            catch(Exception E)
            {
                Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página do author. Id de entrada: " + Id + ". Erro: " + E.Message, "vtnorton.com");
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
                Repeater1.DataSource = readPost.Post(true, NumberOfPost, StartWith,1);
                Repeater1.DataBind();
            }
            catch(Exception E)
            {
                lblErro.Text = "Erro ao carregar posts desse autor. Eu provavelmente já estou providenciando um concerto para isso, mas por favor, entre em contato comigo. <br /> Erro: " + E.Message + "<br /> Informação adicional: " + E.InnerException;
                Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página do author. Id de entrada: " + Id + ". Erro: " + E.Message, "vtnorton.com");
            }
            

            if (StartWith != 0)
            {
                lblLessPost.Text = "<a href='/blog/?sw=" + (StartWith - NumberOfPost) + "'>Posts mais recentes</a>";
            }
            if (!(Repeater1.Items.Count % NumberOfPost == 0))
            {
                lblMorePost.Text = "<a href='/blog/?sw=" + (StartWith + NumberOfPost) + "'>Posts mais antigos</a>";
            }
        }
    }
}