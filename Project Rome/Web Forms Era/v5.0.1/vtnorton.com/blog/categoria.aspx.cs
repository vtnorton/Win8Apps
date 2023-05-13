using MoonCore.Methods;
using System;

namespace VTNORTON.blog
{
    public partial class categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StartWith, WithPageIAm = 1, ItensPorPagina = 8;
            Create Bug = new Create();
            Read readPost = new Read();
            Read readCateogia = new Read();
            Read readPostRecent = new Read();
            Read readPostPopular = new Read();
            Read numberPost = new Read();

            int numberOfItens = numberPost.NumberOfPosts();

            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            if (Request.QueryString["page"] != null)
                WithPageIAm = Convert.ToInt32(Request.QueryString["page"]);
            try
            {
                rptPosts.DataSource = readPost.Post(ItensPorPagina, StartWith);
                rptPosts.DataBind();
            }
            catch (Exception E)
            {
                Bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao carregar Repeater1 na página de início do blog. Dados: StartWith = " + StartWith + ". Erro: " + E.Message, "vtnorton.com");
                Response.Redirect("/erro/000");
            }
            int NumeroDePaginas = numberOfItens / ItensPorPagina;

            if (WithPageIAm == 1)
                lblMorePosts.Text = "<ul><li class='active'><a href='/blog/categoria.aspx'>1</a></li>";
            else
                lblMorePosts.Text = "<ul><li><a href='/blog/categoria.aspx'>1</a></li>";

            if (WithPageIAm >= 5)
            {
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm - 2) * ItensPorPagina) + "&page=" + (WithPageIAm - 2) + "'>" + (WithPageIAm - 2) + "</a></li>";
                lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm - 1) * ItensPorPagina) + "&page=" + (WithPageIAm - 1) + "'>" + (WithPageIAm - 1) + "</a></li>";
                lblMorePosts.Text += "<li class='active'><a href='#'>" + WithPageIAm + "</a></li>";
                if (WithPageIAm != NumeroDePaginas)
                {
                    if (WithPageIAm == NumeroDePaginas - 1)
                    {
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 2)
                    {
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 3)
                    {
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
                    }
                    else
                    {
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
                    }
                }
            }
            else
            {
                switch (WithPageIAm)
                {
                    case 1:
                        if (NumeroDePaginas != 1)
                        {
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=8&page=2'>2</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=16&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=24&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=32&page=5'>5</a></li>";
                        }
                        break;
                    case 2:
                        lblMorePosts.Text += "<li class='active'><a href='/blog/categoria.aspx?sw=8&page=2'>2</a></li>";
                        if (NumeroDePaginas != 2)
                        {
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=16&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=24&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=32&page=5'>5</a></li>";
                        }
                        break;
                    case 3:
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=8&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/blog/categoria.aspx?sw=16&page=3'>3</a></li>";
                        if (NumeroDePaginas != 3)
                        {
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=24&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=32&page=5'>5</a></li>";
                        }
                        break;
                    case 4:
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=8&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=16&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/blog/categoria.aspx?sw=24&page=4'>4</a></li>";
                        if (NumeroDePaginas != 4)
                            lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=32&page=5'>5</a></li>";
                        break;
                    default:
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=8&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=16&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=24&page=4'>4</a></li>";
                        lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=32&&page=5'>5</a></li>";
                        break;
                }
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/blog/categoria.aspx?sw=" + NumeroDePaginas * ItensPorPagina + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
            }
        }
    }
}