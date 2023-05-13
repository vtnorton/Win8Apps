using AllVtnorton;
using BSharp.Classes;
using BSharp.Methods;
using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON.blog
{
    public partial class post : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Post newPost = new Post();
            Ladon.Methods.Create NewBug = new Ladon.Methods.Create();
            Category newCategory = new Category();
            Author newAuthor = new Author();
            PostRepository repoPost = new PostRepository();
            CategoryRepository repoCategory = new CategoryRepository();
            AuthorRepository repoAuthor = new AuthorRepository();
            SQLCommands sqlComands = new SQLCommands();
           
            int IdWebSite = 10;
            int NumberOfWidget = 5;

            Ladon.Methods.Read widget = new Ladon.Methods.Read();
            try
            {
                Repeater2.DataSource = widget.Post(true, NumberOfWidget, 0, 1);
                Repeater2.DataBind();
            }
            catch(Exception E)
            {
                NewBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página de post. Erro: "+ E.Message, "vtnorton.com");
            }


            int Id = Convert.ToInt32(Request.QueryString["id"]);

            if (repoPost.RetornarID(Id).Online == 1)
            {
                try
                {
                    int IdAuthor = repoPost.RetornarID(Id).IdAuthor;
                    int IdCategory = repoPost.RetornarID(Id).IdCategory;
                    String AuthorName = repoAuthor.RetornarID(IdAuthor).Name;
                    String CategoryName = repoCategory.RetornarID(IdCategory).Name;
                    String TitlePost = repoPost.RetornarID(Id).Title;

                    sqlComands.SQLCommand("UPDATE " + TableNames.Post + " SET Visits = Visits + 1 WHERE Id = " + Id);

                    lblAuthorDescricao.Text = repoAuthor.RetornarID(IdAuthor).Description;
                    lblAuthorJob.Text = repoAuthor.RetornarID(IdAuthor).Job;
                    lblAuthorName.Text = AuthorName;
                    lblAuthorProfile.Text = "<img src = '" + repoAuthor.RetornarID(IdAuthor).URLProfile + "' />";
                    lblProfileBackground.Text = "<div class='profile' style='background: url(" + repoAuthor.RetornarID(IdAuthor).URLCover + ") no-repeat center center fixed; background-size: cover;'>";
                    lblAuthorNamePost.Text = "<a href='/blog/author.aspx?id=" + IdAuthor + "'>" + AuthorName + "</a>";
                    lblCategory.Text = "<a href='/blog/categoria.aspx?id=" + IdCategory + "'>" + CategoryName + "</a>";
                    lblPostContent.Text = repoPost.RetornarID(Id).Content;
                    lblPostDate.Text = repoPost.RetornarID(Id).PostedDate;
                    lblPostTitle.Text = TitlePost;
                    lblSubMenuTitle.Text = "<a class='on' href='/blog/" + repoPost.RetornarID(Id).URL + "'>" + repoPost.RetornarID(Id).Title + "</a>";
                    lblSubMenuCategory.Text = "<a href='/blog/categoria.aspx?id=" + IdCategory + "'>" + CategoryName + "</a>";
                    this.Title = TitlePost + " - Vítor Norton";
                    this.MetaDescription = Strings.GetBetween(Regex.Replace(repoPost.RetornarID(Id).FirstParagraph, @"(<img\/?[^>]+>)", @""), "<p>", "</p>");
                    this.MetaKeywords = CategoryName + ", " + AuthorName + ", vtnorton, windows phone, desenvolvimento, mobile, microsoft, developer, minha vida de merda";
                }
                catch(Exception E)
                {
                    NewBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar o post com o id = " + Id + ". Erro: " + E.Message, "vtnorton.com");
                    Response.Redirect("/erro/500");
                }
            }
            else
            {
                Response.Redirect("/erro/404");
            }
        }
    }
}