using MoonCore.Methods;
using MoonCore.Repository;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace VTNORTON.hidra
{
    public partial class post : System.Web.UI.Page
    {
        private int PostsSelected = 0;
        private int IdAuthor = 1;
        private string Filter;
        private string CategorySelected = "";
        private string LanguageSelected = "";
        private Read readPost = new Read();
        private Create newBug = new Create();
        private AuthorRepository repoAuthor = new AuthorRepository();
        private CategoryRepository repoCategory = new CategoryRepository();
        private PostRepository repoPost = new PostRepository();
        private AuthorRepository repoAuthorNP = new AuthorRepository();

        private string SelectedFilterLabelMaster()
        {
            string SearchString = txtSearchBox.Text;


            if (ddlCategory.Text == "108")
                CategorySelected = " de todas as categorias ";
            else
                CategorySelected = " da categoria " + repoCategory.RetornarID(int.Parse(ddlCategory.Text)).Name;


                Filter = "Mostrando todos os posts " + LanguageSelected + CategorySelected;

            if (SearchString != null)
                Filter += " e contendo " + SearchString;

            return Filter+= ".";

        }
        protected void RefreshDataBind(int xStartWith, int xIdCategory, string xSearch)
        {
            rptPosts.Controls.Clear();
            try
            {
                lblErro.Text = "";
                if (txtSearchBox.Text == null)
                {
                    rptPosts.Controls.Clear();
                    rptPosts.DataSource = readPost.PostFiltred(25, xStartWith, xIdCategory, null);
                    rptPosts.DataBind();
                    if (rptPosts.Items.Count == 0)
                        lblErro.Text = "<div class='about-content text-center'><p><br/><br/><br/>Não foi encontrado nenhum post no momento com este filtro. </p></div><br/> <br/> <br/> <br/>";
                }
                else
                {
                    rptPosts.Controls.Clear();
                    rptPosts.DataSource = readPost.PostFiltred(25, xStartWith, xIdCategory, xSearch);
                    rptPosts.DataBind();
                    if (rptPosts.Items.Count == 0)
                        lblErro.Text = "<div class='about-content text-center'><p><br/><br/><br/>Não foi encontrado nenhum post no momento com este filtro. </p></div><br/> <br/> <br/> <br/>";
                }
                lblFiltroSelecionado.Text = SelectedFilterLabelMaster();
            }
            catch (Exception E)
            {
                lblErro.Text = "<p>Erro! :-(</h1><hr /><p>Foi encontrado um erro ao carregar, tente novamente. O erro foi reportado ao administrador. <br /> Erro: " + E.Message + " em " + E.InnerException + "</p>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método RefreshDataBind em /p/manage/post.aspx. Erro: " + E.Message, "hidra.vtnorton.com");
            }
        }
        protected DataTable BindDDlCategory()
        {
            return new Read().Category();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int IdEditar = 1, WithPageIAm = 1, ItensPorPagina = 20;
            Read readAuthor = new Read();
            PostRepository postRepo = new PostRepository();
            Read numberOf = new Read();

            int numberOfItens = numberOf.NumberOfPosts();

            if (!IsPostBack)
            {
                rptPosts.DataSource = readPost.Post(ItensPorPagina, 0);
                rptPosts.DataBind();

                if (rptPosts.Items.Count == 0)
                {
                    lblErro.Text = "<div class='about-content text-center'><p><br/><br/><br/>Não foi encontrado nenhum post no momento. Começe a escrever um agora mesmo! </p></div><br/> <br/> <br/> <br/>";
                }
            }

            if (Request.QueryString["IdEditar"] != null)
            {
                IdEditar = Convert.ToInt32(Request.QueryString["IdEditar"]);
                txtTitle.Text = repoPost.RetornarID(IdEditar).Title;
                CKEditor1.Text = repoPost.RetornarID(IdEditar).Content;
                btnPublish.Text = "<span class='btn btn-transparent'><i class='fa fa-cloud-upload' style='margin-right: 15px'></i>Atualizar post</span>";
            }

            if (!IsPostBack)
            {
                ddlCategory.DataSource = BindDDlCategory();
                if (!IsPostBack)
                {
                    ddlCategory.DataTextField = "Name";
                    ddlCategory.DataValueField = "Id";
                }
                ddlCategory.DataBind();

                if (ddlCategory.Items.Count == 0)
                    ddlCategory.Items.Insert(0, new ListItem("Não há nenhuma categoria cadastrada", "108", true));
                else
                    ddlCategory.Items.Insert(0, new ListItem("Todas as categorias", "108", true));

                ddlCategoryNP.DataSource = BindDDlCategory();
                if (!IsPostBack)
                {
                    ddlCategoryNP.DataTextField = "Name";
                    ddlCategoryNP.DataValueField = "Id";
                }
                ddlCategoryNP.DataBind();
                if (ddlCategoryNP.Items.Count == 0)
                    ddlCategoryNP.Items.Insert(0, new ListItem("Não há nenhuma categoria cadastrada", "108", true));
                else
                    ddlCategoryNP.Items.Insert(0, new ListItem("Escolha uma categoria", "108", true));
                if (Request.QueryString["IdEditar"] != null)
                    ddlCategoryNP.SelectedValue = repoPost.RetornarID(IdEditar).IdCategory.ToString();
            }
            int NumeroDePaginas = numberOfItens / ItensPorPagina;

            if (WithPageIAm == 1)
                lblMorePosts.Text = "<ul><li class='active'><a href='/hidra/index.aspx'>1</a></li>";
            else
                lblMorePosts.Text = "<ul><li><a href='/hidra/index.aspx'>1</a></li>";

            if (WithPageIAm >= 5)
            {
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm - 2) * ItensPorPagina) + "&page=" + (WithPageIAm - 2) + "'>" + (WithPageIAm - 2) + "</a></li>";
                lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm - 1) * ItensPorPagina) + "&page=" + (WithPageIAm - 1) + "'>" + (WithPageIAm - 1) + "</a></li>";
                lblMorePosts.Text += "<li class='active'><a href='#'>" + WithPageIAm + "</a></li>";
                if (WithPageIAm != NumeroDePaginas)
                {
                    if (WithPageIAm == NumeroDePaginas - 1)
                    {
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 2)
                    {
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                    }
                    else if (WithPageIAm == NumeroDePaginas - 3)
                    {
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
                    }
                    else
                    {
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 1) * ItensPorPagina) + "&page=" + (WithPageIAm + 1) + "'>" + (WithPageIAm + 1) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((WithPageIAm + 2) * ItensPorPagina) + "&page=" + (WithPageIAm + 2) + "'>" + (WithPageIAm + 2) + "</a></li>";
                        lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + ((NumeroDePaginas - 1) * ItensPorPagina) + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";
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
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=20&page=2'>2</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=40&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 2:
                        lblMorePosts.Text += "<li class='active'><a href='/hidra/index.aspx?sw=20&page=2'>2</a></li>";
                        if (NumeroDePaginas != 2)
                        {
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=40&page=3'>3</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 3:
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/hidra/index.aspx?sw=40&page=3'>3</a></li>";
                        if (NumeroDePaginas != 3)
                        {
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=60&page=4'>4</a></li>";
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=80&page=5'>5</a></li>";
                        }
                        break;
                    case 4:
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=40&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li class='active'><a href='/hidra/index.aspx?sw=60&page=4'>4</a></li>";
                        if (NumeroDePaginas != 4)
                            lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=80&page=5'>5</a></li>";
                        break;
                    default:
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=20&page=2'>2</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=40&page=3'>3</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=60&page=4'>4</a></li>";
                        lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=80&&page=5'>5</a></li>";
                        break;
                }
                lblMorePosts.Text += "<li><a href='#'>...</a></li>";
                lblMorePosts.Text += "<li><a href='/hidra/index.aspx?sw=" + NumeroDePaginas * ItensPorPagina + "&page=" + NumeroDePaginas + "'>" + NumeroDePaginas + "</a></li>";

                lblMorePostTop.Text = lblMorePosts.Text;
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            rptPosts.DataSource = null;
            rptPosts.DataBind();
            RefreshDataBind(0, int.Parse(ddlCategory.Text), txtSearchBox.Text);
        }
        protected void btnPublish_Click(object sender, EventArgs e)
        {
            Create newPost = new Create();
            Update updatePost = new Update();
            if (txtTitle.Text != null)
            {
                if (CKEditor1.Text != null)
                {
                    if (Convert.ToInt32(ddlCategory.SelectedValue) == 108)
                        lblInfo.Text = "<p>Por favor, selecione uma categoria clicando em opções.</p>";
                    else
                    {
                        Boolean Worked;

                        if (Request.QueryString["IdEditar"] != null)
                        {
                            //Worked = false; updatePost.UpdatePost(int.Parse(Request.QueryString["IdEditar"]), int.Parse(ddlCategory.SelectedValue), txtTitle.Text, CKEditor1.Text, Avalible);
                        }
                        else
                          //  Worked = false; newPost.NewPost(int.Parse(ddlCategory.SelectedValue), txtTitle.Text, CKEditor1.Text, Avalible);

                        if (false)
                        {
                            txtTitle.Text = "";
                            CKEditor1.Text = "";
                            int Id = readPost.PostLastId();
                            String URL = "www.vtnorton.com";
                            String URLPostID = "http://" + URL + "/blog/post.aspx?Id=" + readPost.PostLastId();
                            String URLPost = "http://" + URL + "/blog/" + repoPost.RetornarID(Id).URL;
                            lblInfo.Text = "<p>Seu post foi publicado com sucesso!<br />O link para a sua postagem é: <br/><ul><li>Link com Id: <a target='_blank' href='" + URLPostID + "'>" + URLPostID + "</a></li><li>Link com URL padrão: <a target='_blank' href='" + URLPost + "'>" + URLPost + "</a></li></ul></p>";
                        }
                        else
                            lblInfo.Text = "<article><p>Houve um erro desconhecido no servidor. <br />Tente alguma das seguintes soluções: <br/><ul><li>Nos atributos da imagem, retire qualquer acentuação gráfica</li><li>Tente novamente.</li></ul></p></article>";
                    }
                }
                else
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, escreva a sua postagem.</p></div>";

            }
            else
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, insira o título da postagem.</p></div>";

            this.ClientScript.RegisterStartupScript(this.GetType(), "navigate", "document.getElementById('newpost').scrollIntoView();", true);
        }

        protected void delete_Command(object sender, CommandEventArgs e)
        {
            Delete deletePost = new Delete();
            try
            {
                deletePost.DeletePost(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/hidra/post.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar post: " + ex.Message;
            }
        }
    }
}