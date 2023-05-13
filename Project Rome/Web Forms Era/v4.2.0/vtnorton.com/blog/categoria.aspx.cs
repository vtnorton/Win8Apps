using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Web;

namespace VTNORTON.blog
{
    public partial class categoria : System.Web.UI.Page
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
            CategoryRepository repoCategory = new CategoryRepository();
            Read widget = new Read();
            Create Bug = new Create();

            try
            {
                try
                {
                    Repeater2.DataSource = widget.Post(true, NumberOfWidget, 0, 1);
                    Repeater2.DataBind();
                }
                catch(Exception E)
                {
                    Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página de category. Id de entrada: " + Id + ". Erro: " + E.Message, "vtnorton.com");
                }
                String CategoryName = repoCategory.RetornarID(Id).Name;

                this.Title = CategoryName + " - Vítor Norton";
                lblCategoryNameSubtitle.Text = "<li><a class='on' href='/blog/category.aspx?id=" + Id + "'>" + CategoryName + "</a></li>";
                lblCategoryDescription.Text = repoCategory.RetornarID(Id).Description;
                lblCategoryImage.Text = "<img src = '" + repoCategory.RetornarID(Id).URLIcon + "' />";
                lblCategoryName.Text = CategoryName;
                lblProfileBackground.Text = "<div class='category' style='background: url(" + repoCategory.RetornarID(Id).URLCover + ") no-repeat center center fixed; background-size: cover;'>";

                try
                {
                    Repeater1.DataSource = readPost.PostByCategory(true, NumberOfPost, StartWith, Id);
                    Repeater1.DataBind();
                }
                catch(Exception E)
                {
                    lblErro.Text = "Não há nenhum artigo nessa categoria, ou enfrentamos um problema sério que será corrigido em breve. :-) <br /> Erro: " + E.Message + "<br /> Informação adicional: " + E.InnerException;
                    Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página de category. Id de entrada: " + Id + ". Erro: " + E.Message, "vtnorton.com");
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
            catch
            {
                Response.Redirect("http://www.vtnorton.com/blog/");
            }
        }
    }
}