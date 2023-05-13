using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.manage
{
    public partial class category : System.Web.UI.Page
    {
        private int StartWith;
        private int Showed = 25, Listar, OrderBy;
        private String Filter, SearchString, SearchStringURL;
        private Read readCategoria = new Read();
        private Create newBug = new Create();
        private String SelectedFilterLabel()
        {
            SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlMostrar.Text);


            Filter = "Será mostrado todos as categorias";

            if (Convert.ToInt32(ddlOrderBy.Text) == 0)
                Filter += "";
            else if (Convert.ToInt32(ddlOrderBy.Text) == 1)
                Filter += " ordenadas por ordem alfabética";
            else
                Filter += " ordenadas por ordem alfabética inversa";

            if (SearchString == null)
            {
                Filter += " (sendo " + Showed + " por página).";
            }
            else
            {
                Filter += " contendo " + SearchString + " (sendo " + Showed + " por página).";
            }


            return Filter;

        }
        private String SelectedFilterLabelMaster()
        {
            SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlMostrar.Text);

            Filter = "Mostrando todos as categorias";

            if (Convert.ToInt32(ddlOrderBy.Text) == 0)
                Filter += "";
            else if (Convert.ToInt32(ddlOrderBy.Text) == 1)
                Filter += " ordenadas por ordem alfabética";
            else
                Filter += " ordenadas por ordem alfabética inversa";

            if (SearchString == null)
            {
                Filter += " (sendo " + Showed + " por página).";
            }
            else
            {
                Filter += " contendo " + SearchString + " (sendo " + Showed + " por página).";
            }

            return Filter;

        }
        private void RefreshDataBind(int xStartWith, int xNumberOfPosts, int xOrderBy, String xSearch)
        {
            try
            {
                lblErro.Text = "";
                rptCategoria.Controls.Clear();
                rptCategoria.DataSource = null;
                rptCategoria.DataBind();
                if (xSearch == null)
                {
                    rptCategoria.DataSource = readCategoria.Category(xNumberOfPosts, xStartWith, xOrderBy);
                    rptCategoria.DataBind();
                }
                else
                {
                    rptCategoria.DataSource = readCategoria.Category(xNumberOfPosts, xStartWith, xOrderBy, xSearch);
                    rptCategoria.DataBind();
                }
                lblSelecionado.Text = SelectedFilterLabelMaster();
            }
            catch(Exception E)
            {
                lblErro.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Foi encontrado um erro ao carregar, tente novamente. O erro foi reportado ao administrador. <br /> Erro: "+E.Message+" em "+ E.InnerException+"</p></div>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método RefreshDataBind em /p/manage/category.aspx" + E.Message, "hidra.vtnorton.com");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["sw"] != null)
                    StartWith = Convert.ToInt32(Request.QueryString["sw"]);
                else
                    StartWith = 0;

                if (Request.QueryString["listar"] != null)
                {
                    Listar = Convert.ToInt32(Request.QueryString["listar"]);
                    ddlMostrar.SelectedValue = Listar.ToString();
                }
                else
                    Listar = Convert.ToInt32(ddlMostrar.Text);

                if (Request.QueryString["ob"] != null)
                {
                    OrderBy = Convert.ToInt32(Request.QueryString["ob"]);
                    ddlOrderBy.SelectedValue = OrderBy.ToString();
                }
                else
                    OrderBy = 0;

                if (Request.QueryString["ss"] != null)
                {
                    SearchStringURL = Request.QueryString["ss"];
                    txtSearchBox.Text = SearchStringURL;
                }
                else
                    SearchStringURL = null;
            }

            if (!IsPostBack)
            {
                RefreshDataBind(StartWith, Listar, OrderBy, SearchStringURL);
            }
            
            if (StartWith != 0)
            {
                lblLessPost.Text = "<a href='/p/manage/category.aspx?sw=" + (StartWith - Convert.ToInt32(ddlMostrar.Text)) + "&listar=" + ddlMostrar.Text + "&ob=" + ddlOrderBy.Text + "&ss=" + txtSearchBox.Text + "'>Categorias anteriores</a>";
            }
            if (!(rptCategoria.Items.Count % Convert.ToInt32(ddlMostrar.Text) == 0))
            {
                lblMorePost.Text = "<a href='/p/manage/category.aspx?sw=" + (StartWith + Convert.ToInt32(ddlMostrar.Text)) + "&listar=" + ddlMostrar.Text + "&ob=" + ddlOrderBy.Text + "&ss=" + txtSearchBox.Text + "'>Mais categorias</a>";
            }
        }
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblSelecionado.Text = SelectedFilterLabelMaster();
            RefreshDataBind(StartWith, Convert.ToInt32(ddlMostrar.Text), Convert.ToInt32(ddlOrderBy.Text), txtSearchBox.Text);
        }

        protected void ddlOrderBy_TextChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlMostrar_TextChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }
    }
}