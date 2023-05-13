using Ladon.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.manage
{
    public partial class edit_post : System.Web.UI.Page
    {
        private int IdAuthor;
        protected void Page_Load(object sender, EventArgs e)
        {
            IdAuthor = 1;
        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            Update UpdatePost = new Update();
            if (txtTitle.Text != null)
            {
                int Avalible;
                if (cbxAvabible.Checked)
                    Avalible = 1;
                else
                    Avalible = 0;
                Boolean Worked = UpdatePost.UpdatePost(Convert.ToInt32(ddlCategoria.SelectedValue), IdAuthor, txtTitle.Text, CKEditor1.Text, Avalible);
                if (Worked)
                {
                    lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p>Seu post foi atualizado com sucesso!</p></div>";
                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Houve um erro desconhecido no servidorr.</p></div>";
                }

            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor, insira o título da postagem.</p></div>";
            }
        }
    }
}