using Ladon.Methods;
using System;

namespace HidraOnline.p.manage
{
    public partial class bugs : System.Web.UI.Page
    {
        int StartWith, intLoad, Showed = 25, PostsSelected, Tipo, OrdenarPor;
        String Filter, strOrdenarPor, strStatus, Status, srtTipo;
        Read readBug = new Read();
        Create newBug = new Create();
        private String SelectedFilterLabel()
        {
            String SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlCarregar.Text);
            PostsSelected = Convert.ToInt32(rblSystem.SelectedValue);
            OrdenarPor = Convert.ToInt32(ddlOrdenar.SelectedValue);
            Tipo = Convert.ToInt32(ddlType.SelectedValue);

            if (OrdenarPor == 1)
                strOrdenarPor = " ordenado por data de publicação";
            else
                strOrdenarPor = " ordenado por quantidade de votos";

            switch (Convert.ToInt32(ddlStatus.Text))
            {
                case 0:
                    strStatus = "";
                    break;
                case 1:
                    strStatus = " somente os recebidos";
                    break;
                case 2:
                    strStatus = " somente os que estão em andamento";
                    break;
                case 3:
                    strStatus = " somente os que estarão concertados na proxíma atualização";
                    break;
                case 4:
                    strStatus = " somente os cancelados (avulsos)";
                    break;
                case 5:
                    strStatus = " somente os concluidos";
                    break;
                case 6:
                    strStatus = " somente os não recebidos";
                    break;
            }
            if (Tipo == 0)
                srtTipo = "feedbacks";
            else if (Tipo == 1)
                srtTipo = "sugestões";
            else
                srtTipo = "problemas";


            if (PostsSelected == 0)
                Filter = "Será mostrado todos os(as) " + srtTipo + "  " + strOrdenarPor + " e" + strStatus;
            else if (PostsSelected == 1)
                Filter = "Será mostrado " + srtTipo + " do sistema " + strOrdenarPor + " e" + strStatus;
            else
                Filter = "Será mostrado " + srtTipo + " dos usuarios " + strOrdenarPor + " e" + strStatus;

            if (SearchString == null)
                Filter += " (sendo " + Showed + " por página).";
            else
                Filter += " contendo " + SearchString + " (sendo " + Showed + " por página).";

            return Filter;

        }

        private String SelectedFilterLabelMaster()
        {
            String SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlCarregar.Text);
            PostsSelected = Convert.ToInt32(rblSystem.SelectedValue);
            OrdenarPor = Convert.ToInt32(ddlOrdenar.SelectedValue);
            Tipo = Convert.ToInt32(ddlType.SelectedValue);

            if (OrdenarPor == 1)
                strOrdenarPor = " ordenado por data de publicação";
            else
                strOrdenarPor = " ordenado por quantidade de votos";

            switch (Convert.ToInt32(ddlStatus.Text))
            {
                case 0:
                    strStatus = "";
                    break;
                case 1:
                    strStatus = " somente os recebidos";
                    break;
                case 2:
                    strStatus = " somente os que estão em andamento";
                    break;
                case 3:
                    strStatus = " somente os que estarão concertados na proxíma atualização";
                    break;
                case 4:
                    strStatus = " somente os cancelados (avulsos)";
                    break;
                case 5:
                    strStatus = " somente os concluidos";
                    break;
                case 6:
                    strStatus = " somente os não recebidos";
                    break;
            }

            if (Tipo == 0)
                srtTipo = "feedbacks";
            else if (Tipo == 1)
                srtTipo = "sugestões";
            else
                srtTipo = "problemas";


            if (PostsSelected == 0)
                Filter = "Mostrando todos os(as) " + srtTipo + "  " + strOrdenarPor + " e" + strStatus;
            else if (PostsSelected == 1)
                Filter = "Mostrando " + srtTipo + " do sistema " + strOrdenarPor + " e" + strStatus;
            else
                Filter = "Mostrando " + srtTipo + " dos usuarios " + strOrdenarPor + " e" + strStatus;

            if (SearchString == null)
                Filter += " (sendo " + Showed + " por página).";
            else
                Filter += " contendo " + SearchString + " (sendo " + Showed + " por página).";

            return Filter;

        }

        protected void btnLoadMore_Click(object sender, EventArgs e)
        {
            StartWith = Convert.ToInt32(ddlCarregar.Text);
            if (SelectedFilterLabelMaster() != null)
            {
                Repeater1.DataSource = readBug.Bug(intLoad, StartWith);
                Repeater1.DataBind();
            }
            else
            {
                RefreshDataBind(intLoad, StartWith, Convert.ToInt32(ddlType.Text), Convert.ToInt32(rblSystem.Text), Convert.ToInt32(ddlOrdenar.Text), ddlStatus.Text);
            }
            if (!(Repeater1.Items.Count%Convert.ToInt32(ddlCarregar.Text)==0))
            {
                btnLoadMore.Visible = false;
            }
            
        }

        protected void RefreshDataBind(int xLoad, int xStartWith, int xTipo, int xPostsSelected, int xOrderBy, String xStatus)
        {
            try
            {
                lblErro.Text = "";
                if (txtSearchBox.Text == null)
                {
                    Repeater1.DataSource = readBug.Bug(xLoad, xStartWith, xTipo, xPostsSelected, xOrderBy, xStatus, null);
                    Repeater1.DataBind();
                    if (Repeater1.Items.Count == 0)
                    {
                        lblErro.Text = "Não foi encontrado nenhum item.";
                    }
                }
                else
                {
                    Repeater1.DataSource = readBug.Bug(xLoad, xStartWith, xTipo, xPostsSelected, xOrderBy, xStatus, txtSearchBox.Text);
                    Repeater1.DataBind();

                    if (Repeater1.Items.Count == 0)
                    {
                        lblErro.Text = "Não foi encontrado nenhum item.";
                    }
                }
                lblSelecionado.Text = SelectedFilterLabelMaster();
            }
            catch (Exception E)
            {
                lblErro.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Foi encontrado um erro ao carregar, tente novamente. O erro foi reportado ao administrador. <br /> Erro: " + E.Message + " em " + E.InnerException + "</p></div>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método RefreshDataBind em /p/manage/bugs.aspx. Erro: " + E.Message, "hidra.vtnorton.com");
            }
        }
        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlCarregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(ddlStatus.Text))
            {
                case 0:
                    Status = "Todos";
                    break;
                case 1:
                    Status = "Recebido";
                    break;
                case 2:
                    Status = "Em andamento";
                    break;
                case 3:
                    Status = "Disponivel na atualização";
                    break;
                case 4:
                    Status = "Cancelado";
                    break;
                case 5:
                    Status = "Concluído";
                    break;
                case 6:
                    Status = "Não recebido";
                    break;
            }
            lblSelecionado.Text = SelectedFilterLabelMaster();
            Repeater1.Controls.Clear();
            Repeater1.DataSource = null;
            Repeater1.DataBind();
            RefreshDataBind(intLoad, StartWith, Tipo, PostsSelected, OrdenarPor, Status);
            
        }

        protected void rblSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["sw"] != null)
                StartWith = Convert.ToInt32(Request.QueryString["sw"]);
            else
                StartWith = 0;

            if (Request.QueryString["load"] != null)
                intLoad = Convert.ToInt32(Request.QueryString["load"]);
            else
                intLoad = 25;

            Page.MaintainScrollPositionOnPostBack = true;

            if (!IsPostBack)
            {
                Repeater1.DataSource = readBug.Bug(intLoad, StartWith);
                Repeater1.DataBind();
            }

            if (Repeater1.Items.Count != Convert.ToInt32(ddlCarregar.Text))
            {
                btnLoadMore.Visible = false;
            }
        }
    }
}