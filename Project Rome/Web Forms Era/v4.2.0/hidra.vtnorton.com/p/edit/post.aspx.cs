using AllVtnorton;
using Ladon.Methods;
using Ladon.Repository;
using System;

namespace HidraOnline.p.edit
{
    public partial class post : System.Web.UI.Page
    {
        private int xOnline;
        private int IdPost;
        private int IdAuthor = Setting.IdAuthor;
        private Read readCategory = new Read();
        private AuthorRepository repoAuthor = new AuthorRepository();
        private PostRepository repoPost = new PostRepository();
        private SQLCommands sqlComands;
        protected void Page_Load(object sender, EventArgs e)
        {
            IdPost = Convert.ToInt32(Request.QueryString["Id"]);
            if (!IsPostBack)
            {
                lblAuthor.Text = repoPost.RetornarID(IdPost).AuthorName;
                lblPostedDate.Text = repoPost.RetornarID(IdPost).PostedDate;
                lblUpdatedDate.Text = repoPost.RetornarID(IdPost).UpdatedDate;
                if (repoPost.RetornarID(IdPost).Online == 1)
                {
                    lblVisibilit.Text = "O post está marcado como visível";
                }
                else
                {
                    lblVisibilit.Text = "O post não está visível";
                }
                lblVisits.Text = repoPost.RetornarID(IdPost).Visits.ToString();
                txtTitle.Text = repoPost.RetornarID(IdPost).Title;
                CKEditor1.Text = repoPost.RetornarID(IdPost).Content;

                if (!IsPostBack)
                {
                    ddlCategory.DataSource = readCategory.Category();
                    if (!IsPostBack)
                    {
                        ddlCategory.DataTextField = "Name";
                        ddlCategory.DataValueField = "Id";
                    }
                    ddlCategory.DataBind();
                    ddlCategory.SelectedValue = repoPost.RetornarID(IdPost).IdCategory.ToString();
                }

                if (repoPost.RetornarID(IdPost).IdAuthor != IdAuthor)
                {
                    btnPublish.Enabled = false;
                    txtTitle.Enabled = false;
                    CKEditor1.Enabled = false;
                    ddlCategory.Enabled = false;
                }
            }

        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            String URL = repoAuthor.RetornarID(IdAuthor).URL;
            String URLPostID = "http://" + URL + "/blog/post.aspx?Id=" + IdPost;
            String URLPost = "http://" + URL + "/blog/" + repoPost.RetornarID(IdPost).URL;
            Update updatePost = new Update();
            Create newBug = new Create();
            if (cbxAvabible.Checked)
                xOnline = 1;
            else
                xOnline = 0;
            try
            {
                if (cbxNullVisits.Checked)
                    sqlComands.SQLCommand("UPDATE " + TableNames.Post + " SET Visits = 0 WHERE Id = " + IdPost);
                //updatePost.UpdatePost(IdPost, Convert.ToInt32(ddlCategory.Text), repoPost.RetornarID(IdPost).IdAuthor, txtTitle.Text, CKEditor1.Text, xOnline);
                Boolean Worked = updatePost.UpdatePost(IdPost, Convert.ToInt32(ddlCategory.Text), repoPost.RetornarID(IdPost).IdAuthor, txtTitle.Text, CKEditor1.Text, xOnline);
                if (Worked)
                {
                    lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><article><p>Seu post foi publicado com sucesso!<br />O link para a sua postagem é: <br/><ul><li>Link com Id: <a target='_blank' href='" + URLPostID + "'>" + URLPostID + "</a></li><li>Link com URL padrão: <a target='_blank' href='" + URLPost + "'>" + URLPost + "</a></li></ul></p></article></div>";
                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><article><p>Seu post não foi publicado com sucesso, mas o contador de visitas foi zerado.!<br />O link para a sua postagem é: <br/><ul><li>Link com Id: <a target='_blank' href='" + URLPostID + "'>" + URLPostID + "</a></li><li>Link com URL padrão: <a target='_blank' href='" + URLPost + "'>" + URLPost + "</a></li></ul></p></article></div>";
                }
            }
            catch(Exception E)
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><article><p>Houve um erro ao publicar o seu post. Erro no servidor, contate o administrador do sistema. <br /> Erro: " + E.Message + " em " + E.InnerException + "</p></article></div>";
                newBug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao executar método UpdatePost em /p/edit/post.aspx. Erro: " + E.Message, "hidra.vtnorton.com");
            }

        }
    }
}