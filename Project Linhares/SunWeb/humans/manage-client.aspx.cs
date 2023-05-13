using SunCore;
using SunCore.Methods;
using System;

namespace SunWeb.humans
{
    public partial class manage_client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StartWith, WithPageIAm = 1, ItensPorPagina = 20;
            Read readClient = new Read();
            Read numberOf = new Read();

            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            if (Request.QueryString["page"] != null)
                WithPageIAm = Convert.ToInt32(Request.QueryString["page"]);

            int numberOfItens = numberOf.NumberOfItens(1, TableNames.Client);

            if (!IsPostBack)
            {
                try
                {
                    rptClient.DataSource = readClient.Client(1, ItensPorPagina, StartWith);
                    rptClient.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                if (rptClient.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum cliente no momento. Adicione um!</p></div>";

            }

            int NumeroDePaginas = numberOfItens / ItensPorPagina;

            if (WithPageIAm == 1)
                lblMorePosts.Text = "<ul><li class='active'><a href='/humans/manage-client.aspx'>1</a></li>";
            else
                lblMorePosts.Text = "<ul><li><a href='/humans/manage-client.aspx'>1</a></li>";

            if (WithPageIAm >= 5)
            {
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm - 2) * ItensPorPagina) + "&page=" + (WithPageIAm - 2) + "'>" + (WithPageIAm - 2) + "</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm - 1) * ItensPorPagina) + "&page=" + (WithPageIAm - 1) + "'>" + (WithPageIAm - 1) + "</a></li>";
                lblMorePosts.Text += "<li class='active'><a href='#'>" + WithPageIAm + "</a></li>";
                if (WithPageIAm != NumeroDePaginas)
                {
                    if (WithPageIAm == NumeroDePaginas - 1)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 2)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 3)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
                    }
                    else
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
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
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=20&page=2'>2</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=40&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 2:
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-client.aspx?sw=20&page=2'>2</a></li>";
                        if (NumeroDePaginas != 2)
                        {
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=40&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 3:
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-client.aspx?sw=40&page=3'>3</a></li>";
                        if (NumeroDePaginas != 3)
                        {
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 4:
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=40&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-client.aspx?sw=60&page=4'>4</a></li>";
                        if (NumeroDePaginas != 4)
                            lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=80&page=5'>5</a></li>";
                        break;
                    default:
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=40&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=60&page=4'>4</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=80&&page=5'>5</a></li>";
                        break;
                }
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-client.aspx?sw=" + NumeroDePaginas * ItensPorPagina + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
            }
            lblMorePostTop.Text = lblMorePosts.Text;
        }
        protected void delete_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Delete deleteClient = new Delete();
            try
            {
                deleteClient.DeleteClient(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/humans/manage-client.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar cliente: " + ex.Message;
            }
        }
    }
}