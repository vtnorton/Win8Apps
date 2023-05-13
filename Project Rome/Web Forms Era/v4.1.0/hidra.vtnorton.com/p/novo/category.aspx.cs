using Ladon.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.novo
{
	public partial class category : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            
		}
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Create newCategory = new Create();
            if(txtName.Text != null)
            {
                if(txtDescricao.Text != null)
                {
                    if(txtURLCover.Text != null)
                    {
                        if(txtURLIcon.Text != null)
                        {
                            Boolean Worked = newCategory.NewCategory(txtName.Text, txtDescricao.Text, txtURLIcon.Text, txtURLCover.Text);
                            if (Worked)
                            {
                                txtName.Text = "";
                                txtDescricao.Text = "";
                                txtURLCover.Text = "";
                                txtURLIcon.Text = "";
                                Label1.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p> A categoria foi criada com êxito!</p></div>";
                            }
                            else
                            {
                                Label1.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Houve um erro desconhecido no servidor.</p></div>";
                            }

                        }
                        else
                        {
                            Label1.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa inserir a URL do ícone.</p></div>"; 
                        }
                    }
                    else
                    {
                        Label1.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa inserir a URL da capa.</p></div>"; 
                    }
                    
                }
                else
                {
                    Label1.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa inserir a descrição da categoria.</p></div>"; 
                }
                
            }
            else
            {
                Label1.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa inserir o nome da categoria.</p></div>"; 
            }
            
        }
    }
}