using SunCore;
using SunCore.Methods;
using System;

namespace SunWeb.humans
{
    public partial class manage_employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int StartWith, xTemp = 0, WithPageIAm = 1, ItensPorPagina = 20;
            Read readEmployee = new Read();
            Read numberOf = new Read();

            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            if (Request.QueryString["temp"] != null)
                xTemp = Convert.ToInt32(Request.QueryString["temp"]);

            if (Request.QueryString["page"] != null)
                WithPageIAm = Convert.ToInt32(Request.QueryString["page"]);

            int numberOfItens = numberOf.NumberOfItensEmployee(1, TableNames.Employee, xTemp);

            if (!IsPostBack)
            {
                try
                {
                    if (xTemp == 0)
                        rptEmployee.DataSource = readEmployee.Employee(1, false, ItensPorPagina, StartWith);
                    else if (xTemp == 1)
                        rptEmployee.DataSource = readEmployee.Employee(1, true, ItensPorPagina, StartWith);
                    else
                        rptEmployee.DataSource = readEmployee.Employee(1, ItensPorPagina, StartWith);
                    rptEmployee.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                if (rptEmployee.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum empregado no momento. </p></div>";

            }

            int NumeroDePaginas = numberOfItens / ItensPorPagina;

            if (WithPageIAm == 1)
                lblMorePosts.Text = "<ul><li class='active'><a href='/humans/manage-employee.aspx?temp=" + xTemp + "'>1</a></li>";
            else
                lblMorePosts.Text = "<ul><li><a href='/humans/manage-employee.aspx?temp=" + xTemp + "'>1</a></li>";

            if (WithPageIAm >= 5)
            {
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm - 2) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm - 2) + "'>" + (WithPageIAm - 2) + "</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm - 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm - 1) + "'>" + (WithPageIAm - 1) + "</a></li>";
                lblMorePosts.Text += "<li class='active'><a href='#'>" + WithPageIAm + "</a></li>";
                if (WithPageIAm != NumeroDePaginas)
                {
                    if (WithPageIAm == NumeroDePaginas - 1)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 2)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 3)
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
                    }
                    else
                    {
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&temp=" + xTemp + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
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
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=20&temp=" + xTemp + "&page=2'>2</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=40&temp=" + xTemp + "&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=60&temp=" + xTemp + "&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=80&temp=" + xTemp + "&page=5'>5</a></li>";
                        }
                        break;
                    case 2:
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-employee.aspx?sw=20&temp=" + xTemp + "&page=2'>2</a></li>";
                        if (NumeroDePaginas != 2)
                        {
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=40&temp=" + xTemp + "&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=60&temp=" + xTemp + "&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=80&temp=" + xTemp + "&page=5'>5</a></li>";
                        }
                        break;
                    case 3:
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=20&temp=" + xTemp + "&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-employee.aspx?sw=40&temp=" + xTemp + "&page=3'>3</a></li>";
                        if (NumeroDePaginas != 3)
                        {
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=60&temp=" + xTemp + "&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=80&temp=" + xTemp + "&page=5'>5</a></li>";
                        }
                        break;
                    case 4:
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=20&temp=" + xTemp + "&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=40&temp=" + xTemp + "&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/humans/manage-employee.aspx?sw=60&temp=" + xTemp + "&page=4'>4</a></li>";
                        if (NumeroDePaginas != 4)
                            lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=80&temp=" + xTemp + "&page=5'>5</a></li>";
                        break;
                    default:
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=20&temp=" + xTemp + "&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=40&temp=" + xTemp + "&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=60&temp=" + xTemp + "&page=4'>4</a></li>";
                        lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=80&temp=" + xTemp + "&page=5'>5</a></li>";
                        break;
                }
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/humans/manage-employee.aspx?sw=" + NumeroDePaginas * ItensPorPagina + "&temp=" + xTemp + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
            }
            lblMorePostTop.Text = lblMorePosts.Text;
        }

        protected void hplTemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("/humans/manage-employee.aspx?temp=1");
        }

        protected void hplFixos_Click(object sender, EventArgs e)
        {
            Response.Redirect("/humans/manage-employee.aspx");
        }

        protected void hplAll_Click(object sender, EventArgs e)
        {
            Response.Redirect("/humans/manage-employee.aspx?temp=2");
        }

        protected void delete_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Delete deleteEmployee = new Delete();
            try
            {
                deleteEmployee.DeleteEmployee(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/humans/manage-employee.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar funcionário: " + ex.Message;
            }
        }
    }
}