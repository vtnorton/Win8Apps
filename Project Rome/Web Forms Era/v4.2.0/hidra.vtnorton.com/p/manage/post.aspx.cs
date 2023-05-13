using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.manage
{
    public partial class post : System.Web.UI.Page
    {
        private int StartWith, Listar, Categoria, Autor, OnlineURL;
        private int PostsSelected = 0;
        private int Showed = 25;
        private String Filter, SearchStringURL;
        private String AuthorSelected = "";
        private String CategorySelected = "";
        private Read readPost = new Read();
        private Create newBug = new Create();
        private AuthorRepository repoAuthor = new AuthorRepository();
        private CategoryRepository repoCategory = new CategoryRepository();
        private String SelectedFilterLabel()
        {
            String SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlMostrar.Text);
            PostsSelected = Convert.ToInt32(rbtPostOnline.SelectedValue);

            if (ddlCategory.Text == "108")
                CategorySelected = " de todas as categorias ";
            else
                CategorySelected = " da categoria " + repoCategory.RetornarID(Convert.ToInt32(ddlCategory.Text)).Name;

            if (ddlAuthor.Text == "108")
                AuthorSelected = " de todos os autores";
            else
                AuthorSelected = " do autor " + repoAuthor.RetornarID(Convert.ToInt32(ddlAuthor.Text)).Name;

            if (PostsSelected == 108)
                Filter = "Será mostrado todos os posts " + CategorySelected + " e" + AuthorSelected;
            else if (PostsSelected == 1)
                Filter = "Será mostrado itens sendo: somente os posts publicados" + CategorySelected + " e" + AuthorSelected;
            else
                Filter = "Será mostrado itens sendo: somente os posts não publicados" + CategorySelected + " e" + AuthorSelected;

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
            String SearchString = txtSearchBox.Text;
            Showed = Convert.ToInt32(ddlMostrar.Text);
            PostsSelected = Convert.ToInt32(rbtPostOnline.SelectedValue);

            if (ddlCategory.Text == "108")
                CategorySelected = " de todas as categorias ";
            else
                CategorySelected = " da categoria " + repoCategory.RetornarID(Convert.ToInt32(ddlCategory.Text)).Name;

            if (ddlAuthor.Text == "108")
                AuthorSelected = " de todos os autores";
            else
                AuthorSelected = " do autor " + repoAuthor.RetornarID(Convert.ToInt32(ddlAuthor.Text)).Name;

            if (PostsSelected == 108)
                Filter = "Mostrando todos os posts " + CategorySelected + " e" + AuthorSelected;
            else if (PostsSelected == 1)
                Filter = "Mostrando itens sendo: somente os posts publicados" + CategorySelected + " e" + AuthorSelected;
            else
                Filter = "Mostrando itens sendo: somente os posts não publicados" + CategorySelected + " e" + AuthorSelected;

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
        protected void RefreshDataBind(int xStartWith, int xNumberOfPosts, int xIdCategory, int xIdAuthor, int xBoolean, String xSearch)
        {
            rptPosts.Controls.Clear();
            try
            {
                lblErro.Text = "";
                if (txtSearchBox.Text == null)
                {
                    rptPosts.Controls.Clear();
                    rptPosts.DataSource = readPost.PostFiltred(true, xNumberOfPosts, xStartWith, xIdCategory, xIdAuthor, xBoolean);
                    rptPosts.DataBind();
                    if (rptPosts.Items.Count == 0)
                    {
                        lblErro.Text = "Não foi encontrado nenhum item.";
                    }
                }
                else
                {
                    rptPosts.Controls.Clear();
                    rptPosts.DataSource = readPost.PostFiltred(true, xNumberOfPosts, xStartWith, xIdCategory, xIdAuthor, xBoolean, xSearch);
                    rptPosts.DataBind();

                    if (rptPosts.Items.Count == 0)
                    {
                        lblErro.Text = "Não foi encontrado nenhum item.";
                    }
                }
                lblSelecionado.Text = SelectedFilterLabelMaster();
            }
            catch(Exception E)
            {
                lblErro.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Foi encontrado um erro ao carregar, tente novamente. O erro foi reportado ao administrador. <br /> Erro: " + E.Message + " em " + E.InnerException + "</p></div>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método RefreshDataBind em /p/manage/post.aspx. Erro: " + E.Message, "hidra.vtnorton.com");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readAuthor = new Read();
            Read readCategory = new Read();
            PostRepository postRepo = new PostRepository();
            if (!IsPostBack)
            {
                if (Request.QueryString["sw"] != null)
                    StartWith = Convert.ToInt32(Request.QueryString["sw"]);
                else
                    StartWith = 0;
            }

            if (!IsPostBack)
            {
                rptPosts.DataSource = readPost.Post(true, Convert.ToInt32(ddlMostrar.Text), StartWith);
                rptPosts.DataBind();
            }

            if (!IsPostBack)
            {
                ddlAuthor.DataSource = readAuthor.Author();
                if (!IsPostBack)
                {
                    ddlAuthor.DataTextField = "Name";
                    ddlAuthor.DataValueField = "Id";
                }
                ddlAuthor.DataBind();
                ddlAuthor.Items.Insert(0, new ListItem("Todos os autores", "108", true));
            }
            if (!IsPostBack)
            {
                ddlCategory.DataSource = readCategory.Category();
                if (!IsPostBack)
                {
                    ddlCategory.DataTextField = "Name";
                    ddlCategory.DataValueField = "Id";
                }
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, new ListItem("Todas as categorias", "108", true));
            }

            if (StartWith != 0)
            {
                lblLessPost.Text = "<a href='/p/manage/post.aspx?sw=" + (StartWith - Convert.ToInt32(ddlMostrar.Text)) + "'>Posts mais recentes</a>";
            }
            if (!(rptPosts.Items.Count % Convert.ToInt32(ddlMostrar.Text) == 0))
            {
                lblMorePost.Text = "<a href='/p/manage/post.aspx?sw=" + (StartWith + Convert.ToInt32(ddlMostrar.Text)) + "'>Posts mais antigos</a>";
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void ddlAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void rbtPostOnline_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }
        protected void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            lblFiltroSelecionado.Text = SelectedFilterLabel();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            rptPosts.DataSource = null;
            rptPosts.DataBind();
            RefreshDataBind(StartWith, Convert.ToInt32(ddlMostrar.Text), Convert.ToInt32(ddlCategory.Text), Convert.ToInt32(ddlAuthor.Text), Convert.ToInt32(rbtPostOnline.Text), txtSearchBox.Text);
        }
    }
}