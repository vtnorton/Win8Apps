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
    public partial class postbycategory : System.Web.UI.Page
    {
        int IdCategory;
        private int StartWith;
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
            Showed = Convert.ToInt32(ddlMostrar.Text);
            Filter = "Será mostrado todos os posts " + CategorySelected + " e" + AuthorSelected;
            Filter += " (sendo " + Showed + " por página).";
            return Filter;
        }
        private String SelectedFilterLabelMaster()
        {
            Showed = Convert.ToInt32(ddlMostrar.Text);
            Filter = "Mostrando todos os posts " + CategorySelected + " e" + AuthorSelected;
            Filter += " (sendo " + Showed + " por página).";
            return Filter;
        }
        protected void RefreshDataBind(int xStartWith, int xNumberOfPosts)
        {
            rptPosts.Controls.Clear();
            try
            {
                lblErro.Text = "";
                rptPosts.Controls.Clear();
                rptPosts.DataSource = readPost.PostByCategory(true, xNumberOfPosts, xStartWith, IdCategory);
                rptPosts.DataBind();
                if (rptPosts.Items.Count == 0)
                {
                    lblErro.Text = "Não foi encontrado nenhum item.";
                }
                lblSelecionado.Text = SelectedFilterLabelMaster();
            }
            catch(Exception E)
            {
                lblErro.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Foi encontrado um erro ao carregar, tente novamente. O erro foi reportado ao administrador. <br /> Erro: " + E.Message + " em " + E.InnerException + "</p></div>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método RefreshDataBind em /p/manage/postbycategory.aspx. Erro: " + E.Message, "hidra.vtnorton.com");
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
                IdCategory = Convert.ToInt32(Request.QueryString["Id"]);
            else
                Response.Redirect("/p/manage/post.aspx");
            RefreshDataBind(StartWith, Convert.ToInt32(ddlMostrar.Text));
            
        }
    }
}