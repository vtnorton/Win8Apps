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
            CategoryRepository repoCategory = new CategoryRepository();
            Read widget = new Read();
            Create Bug = new Create();

            try
            {
                Repeater2.DataSource = widget.Post(true, 5, 0);
                Repeater2.DataBind();
            }
            catch
            {
                Bug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater2 na página de category. Id de entrada: " + Id + ".", "vtnorton.com");
            }
            String CategoryName = repoCategory.RetornarID(Id).Name;

            lblCategoryNameSubtitle.Text = "<li><a class='on' href='/blog/category.aspx?id=" + Id + "'>" + CategoryName + "</a></li>";
            lblCategoryDescription.Text = repoCategory.RetornarID(Id).Description;
            lblCategoryImage.Text = "<img src = '" + repoCategory.RetornarID(Id).URLIcon + "' />";
            lblCategoryName.Text = CategoryName;
            lblProfileBackground.Text = "<div class='category' style='background: url(" + repoCategory.RetornarID(Id).URLCover + ") no-repeat center center fixed; background-size: cover;'>";

            try
            {
                Repeater1.DataSource = readPost.PostByCategory(true, 10, StartWith, Id);
                Repeater1.DataBind();
            }
            catch
            {
                lblErro.Text = "Não há nenhum artigo nessa categoria, ou enfrentamos um problema sério que será corrigido em breve. :-)";
                Bug.NewBug("GoingOn", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página de category. Id de entrada: " + Id + ".", "vtnorton.com");
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