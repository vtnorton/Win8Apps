using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.delete
{
    public partial class post : System.Web.UI.Page
    {
        int IdPost;
        int IdAuthor = Setting.IdAuthor;
        PostRepository repoPost = new PostRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Id"] != null)
                IdPost = Convert.ToInt32(Request.QueryString["Id"]);
            else
                Response.Redirect("/p/manage/post.aspx");

            lblEdit.Text = "<a href='/p/edit/post.aspx?Id=" + IdPost + "'>Editar postagem</a>";

            if (IdAuthor != 4)
            {
                btnExcluir.Enabled = false;
                lblInfo.Text = "<strong>Você precisa ser autor do post ou administrador do sistema para poder exclui-lo.</strong>";
                lblEdit.Text = "";
            }

            lblAuthor.Text = repoPost.RetornarID(IdPost).AuthorName;
            lblCategoria.Text = repoPost.RetornarID(IdPost).CategoryName;
            lblPublishedDate.Text = repoPost.RetornarID(IdPost).PostedDate;
            lblTitle.Text = repoPost.RetornarID(IdPost).Title;
            lblUpdatedDate.Text = repoPost.RetornarID(IdPost).UpdatedDate;
            lblVitis.Text = repoPost.RetornarID(IdPost).Visits + " visitas.";
            lblContent.Text = repoPost.RetornarID(IdPost).Content;

            if(repoPost.RetornarID(IdPost).Online == 1)
            {
                lblOnline.Text = "O post está marcado como visível.";
            }
            else
            {
                lblOnline.Text = "O post não está visível.";
            }

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Delete deletePost = new Delete();
            Boolean Worked = deletePost.DeletePost(IdPost);
            if (Worked)
            {
                Response.Redirect("/p/manage/post.aspx");
            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><article><p>Houve um erro ao deletar o post. Erro no servidor, contate o administrador do sistema.</p></article></div>";
            }
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/p/manage/post.aspx");
        }
    }
}