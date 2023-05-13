using Ladon.Methods;
using Ladon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.crud.create
{
    public partial class post : System.Web.UI.Page
    {
        Read readCategory = new Read();
        PostRepository repoPost = new PostRepository();
        AuthorRepository repoAuthor = new AuthorRepository();
        private int IdAuthor;
        protected void Page_Load(object sender, EventArgs e)
        {
            IdAuthor = Setting.IdAuthor;
            if (!IsPostBack)
            {
                ddlCategory.DataSource = readCategory.Category();
                if (!IsPostBack)
                {
                    ddlCategory.DataTextField = "Name";
                    ddlCategory.DataValueField = "Id";
                }
                ddlCategory.DataBind();
                ddlCategory.Items.Insert(0, new ListItem("Escolha um", "108", true));
            }
        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            Create newPost = new Create();
            if(txtTitle.Text != null)
            {
                if(CKEditor1.Text != null)
                {
                    if(Convert.ToInt32(ddlCategory.SelectedValue) == 108)
                    {
                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, selecione uma categoria.</p></div>";
                    }
                    else
                    {
                        int Avalible;
                        if (cbxAvabible.Checked)
                            Avalible = 1;
                        else
                            Avalible = 0;

                        Boolean Worked = newPost.NewPost(Convert.ToInt32(ddlCategory.SelectedValue), IdAuthor, txtTitle.Text, CKEditor1.Text, Avalible);
                        if (Worked)
                        {
                            txtTitle.Text = "";
                            CKEditor1.Text = "";
                            int Id = readCategory.PostLastId();
                            String URL = repoAuthor.RetornarID(IdAuthor).URL;
                            String URLPostID = "http://" + URL + "/blog/post.aspx?Id=" + readCategory.PostLastId();
                            String URLPost = "http://" + URL + "/blog/" + repoPost.RetornarID(Id).URL;
                            lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><article><p>Seu post foi publicado com sucesso!<br />O link para a sua postagem é: <br/><ul><li>Link com Id: <a target='_blank' href='"+URLPostID+"'>"+ URLPostID + "</a></li><li>Link com URL padrão: <a target='_blank' href='"+ URLPost +"'>"+ URLPost + "</a></li></ul></p></article></div>";
                        }
                        else
                        {
                            lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><article><p>Houve um erro desconhecido no servidor. <br />Tente alguma das seguintes soluções: <br/><ul><li>Nos atributos da imagem, retire qualquer acentuação gráfica</li><li>Tente novamente.</li></ul></p></article></div>";
                        }
                    }
                   
                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, escreva a sua postagem.</p></div>";
                }
               
            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, insira o título da postagem.</p></div>";
            }
            
        }
    }
}