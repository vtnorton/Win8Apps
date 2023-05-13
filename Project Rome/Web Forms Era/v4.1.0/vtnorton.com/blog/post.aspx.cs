using AllVtnorton;
using BSharp.Classes;
using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Create NewBug = new Create();
            Category newCategory = new Category();
            Author newAuthor = new Author();
            PostRepository repoPost = new PostRepository();
            CategoryRepository repoCategory = new CategoryRepository();
            AuthorRepository repoAuthor = new AuthorRepository();
            SQLCommands sqlComands = new SQLCommands();

            Ladon.Methods.Read widget = new Ladon.Methods.Read();
            try
            {
                Repeater2.DataSource = widget.Post(true, 5, 0);
                Repeater2.DataBind();
            }
            catch
            {
                NewBug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página de post.", "vtnorton.com");
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

                    sqlComands.SQLCommand("UPDATE " + TableNames.Post + " SET Visits = Visits + 1 WHERE Id = " + Id);

                    lblAuthorDescricao.Text = repoAuthor.RetornarID(IdAuthor).Description;
                    lblAuthorJob.Text = repoAuthor.RetornarID(IdAuthor).Job;
                    lblAuthorName.Text = AuthorName;
                    lblAuthorProfile.Text = "<img src = '" + repoAuthor.RetornarID(IdAuthor).URLProfile + "' />";
                    lblProfileBackground.Text = "<div class='profile' style='background: url(" + repoAuthor.RetornarID(IdAuthor).URLCover + ") no-repeat center center fixed; background-size: cover;'>";
                    lblAuthorNamePost.Text = "<a href='/blog/author.aspx?id=" + IdAuthor + "'>" + AuthorName + "</a>";
                    lblCategory.Text = "<a href='/blog/category.aspx?id=" + IdCategory + "'>" + CategoryName + "</a>";
                    lblPostContent.Text = repoPost.RetornarID(Id).Content;
                    lblPostDate.Text = repoPost.RetornarID(Id).PostedDate;
                    lblPostTitle.Text = repoPost.RetornarID(Id).Title;
                    lblSubMenuTitle.Text = "<a class='on' href='/blog/" + repoPost.RetornarID(Id).URL + "'>" + repoPost.RetornarID(Id).Title + "</a>";
                    lblSubMenuCategory.Text = "<a href='/blog/category.aspx?id=" + IdCategory + "'>" + CategoryName + "</a>";
                }
                catch
                {
                    NewBug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar o post com o id = " + Id + ".", "vtnorton.com");
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