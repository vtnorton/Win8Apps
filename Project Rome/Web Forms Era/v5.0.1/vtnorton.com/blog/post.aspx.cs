using Core.Methods;
using Core.Shared;
using MoonCore.Classes;
using MoonCore.Methods;
using MoonCore.Repository;
using System;
using System.Text.RegularExpressions;

namespace VTNORTON.blog
{
    public partial class post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Post newPost = new Post();
            Create NewBug = new Create();
            Category newCategory = new Category();
            Author newAuthor = new Author();
            //Read prevNextPost = new Read();
            PostRepository repoPost = new PostRepository();
            AuthorRepository repoAuthor = new AuthorRepository();
            SQLCommands sqlComands = new SQLCommands();

            int Id = int.Parse(Request.QueryString["id"]);
            try
            {
                int IdAuthor = 1;
                int IdCategory = repoPost.RetornarID(Id).IdCategory;
                string AuthorName = repoAuthor.RetornarID(IdAuthor).Name;
                string CategoryName = repoPost.RetornarID(Id).CategoryName;
                string TitlePost = repoPost.RetornarID(Id).Title;

                sqlComands.SQLCommand("UPDATE " + TableNames.Post + " SET Visits = Visits + 1 WHERE Id = " + Id);

                lblAuthorBio.Text = repoAuthor.RetornarID(IdAuthor).Bio;
                lblAuthorName.Text = AuthorName;
                lblAuthorImage.Text = "<img src = '" + repoAuthor.RetornarID(IdAuthor).URLProfile + "' />";
                lblCategoria.Text = "<a href='/blog/categoria.aspx?id=" + IdCategory + "'>" + CategoryName + "</a>";
                lblPost.Text = repoPost.RetornarID(Id).Content;
                lblPostedDate.Text = repoPost.RetornarID(Id).PostedDate;
                //lblPostHTML.Text = repoPost.RetornarID(Id).PostHTML;
                //lblPostHTML.Text = repoPost.RetornarID(Id).URLImage;
                lblVisualizacoes.Text = repoPost.RetornarID(Id).Visits.ToString();
                lblPostTitle.Text = TitlePost;
                this.Title = TitlePost + " - Vítor Norton";
                this.MetaDescription = Strings.GetBetween(Regex.Replace(repoPost.RetornarID(Id).FirstParagraph, @"(<img\/?[^>]+>)", @""), "<p>", "</p>");
                this.MetaKeywords = CategoryName + ", " + AuthorName + ", vtnorton, windows phone, desenvolvimento, mobile, microsoft, developer, sextafeira, sextachegou, sexta chegou";

                //if (prevNextPost.PrevPost(Id) != null)
                //{
                //    lblPrevPost.Text = "<a href='/blog/post.aspx?id=" + prevNextPost.PrevPost(Id) + "' class='prev-post'><i class='fa fa-angle-left fa-2x'></i>Post anterior</a>";
                //}
                //if (prevNextPost.NextPost(Id) != null)
                //{
                //    lblNextPost.Text = "<a href='" + prevNextPost.NextPost(Id) + "' class='next-post pull-right'>Próximo post<i class='fa fa-angle-right fa-2x'></i></a>";
                //}

            }
            catch (Exception E)
            {
                NewBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar o post com o id = " + Id + ". Erro: " + E.Message, "vtnorton.com");
                Response.Redirect("/erro/500");
            }
        }
    }
}