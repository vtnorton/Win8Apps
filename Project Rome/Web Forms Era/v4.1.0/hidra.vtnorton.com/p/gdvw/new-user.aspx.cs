using Ladon.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HidraOnline.p.gdvw
{
    public partial class new_user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool SenhaCheck(String Senha)
        {
            if (Senha != null)
            {
                if ((Senha.Length <= 20) && (Senha.Length >= 8))
                {
                    //Verificar se tem maiuscula
                    //Verificar se tem número
                    //Verificar se tem minúscula
                    //Verificar se tem simbolos
                    return true;
                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>A senha deve ter entre 8 a 20 caracteres!</p></div>";
                    return false;
                }
            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por insira uma senha válida</p></div>";
                return true;
            }
        }
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Create newUser = new Create();
            String Senha = txtSenha.Text;
            if (txtBirthday.Text != null)
            {
                if (txtDescricao.Text != null)
                {
                    if (txtEmail.Text != null)
                    {
                        if (txtName.Text != null)
                        {
                            if (SenhaCheck(Senha))
                            {
                                if (txtURLCover.Text != null)
                                {
                                    if (txtURLProfile.Text != null)
                                    {
                                        if(txtJob.Text != null)
                                        {
                                            bool Worked;
                                            Worked = newUser.NewAuthor(txtName.Text, txtDescricao.Text, txtURLProfile.Text, txtURLCover.Text, txtBirthday.Text, txtEmail.Text, txtSenha.Text, txtJob.Text);

                                            if (Worked)
                                            {
                                                txtURLProfile.Text = "";
                                                txtVerificarSenha.Text = "";
                                                txtURLCover.Text = "";
                                                txtSenha.Text = "";
                                                txtName.Text = "";
                                                txtEmail.Text = "";
                                                txtDescricao.Text = "";
                                                txtBirthday.Text = "";
                                                lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p>O usuário foi criado com sucesso!</p></div>";
                                            }
                                            else
                                            {
                                                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Houve um erro desconhecido no servidor.</p></div>";
                                            }
                                        }
                                        else
                                        {
                                            lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor insira a profissão do usuário.</p></div>";
                                        }
                                        
                                    }
                                    else
                                    {
                                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor insira a URL da imagem de perfil.</p></div>";
                                    }
                                }
                                else
                                {
                                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor insira a URL da imagem da capa.</p></div>";
                                }
                            }
                        }
                        else
                        {
                            lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Insira o nome do usuário.</p></div>";
                        }
                    }
                    else
                    {
                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Insira o e-mail do usuário.</p></div>";
                    }
                }
                else
                {
                    lblInfo.Text = lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor insira a descrição do usuário.</p></div>";
                }
            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Por favor insira a data de nascimento do usuário.</p></div>";
            }

        }

    }
}