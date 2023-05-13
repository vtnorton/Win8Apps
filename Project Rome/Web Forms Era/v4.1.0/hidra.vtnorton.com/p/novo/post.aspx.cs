using BSharp.Methods;
using Ladon.Methods;
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
        private int IdAuthor;
        protected void Page_Load(object sender, EventArgs e)
        {
            IdAuthor = 1;
            RefreshDDL();
        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            Create newPost = new Create();
            if(txtTitle.Text != null)
            {
                if(CKEditor1.Text != null)
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
                        lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p>Seu post foi publicado com sucesso!</p></div>";
                    }
                    else
                    {
                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Houve um erro desconhecido no servidor.</p></div>";
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
        private void RefreshDDL()
        {
            if (!IsPostBack)
            {
                ddlCategory.DataSource = readCategory.Category();
                if (!IsPostBack)
                {
                    ddlCategory.DataTextField = "Name";
                    ddlCategory.DataValueField = "Id";
                }


                ddlCategory.DataBind();
            }
        }
    }
}