using System;
using System.Linq;
using System.Web.UI;
using vtnCore.Methods;
using vtnCore.Stuff;
using VTNORTON.Services;

namespace VTNORTON.talks
{
    public partial class pronatec : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                string[] listaemails = new string[] { "vitor@vtnorton.com", "doh3194@live.com", "jhonath-2012@live.com", "euclidesgsouza@hotmail.com", "marcio.102@bol.com.br", "cassiano.th@gmail.com", "thallytamoreira18@gmail.com", "walacesouza863@gmail.com", "queilabatistafraga@gmail.com", "vinicius.escoralique@yahoo.com.br", "marcelo190993@hotmail.com"};

                if (listaemails.Contains(txtMail.Text.Trim().ToLower()))
                {
                    try
                    {
                        new SendInvitationFormula().SendEmailPT("http://go.microsoft.com/fwlink/?LinkId=532540&mstoken=7JG72-GR9KM-R2TX7-VKDHM-JV2DZ", txtMail.Text);
                        InsertEmail.Insert(txtMail.Text + txtUser.Text, EmailLists.Palestras);
                        lblError.Text = "E-mail cadastrado com sucesso! Cheque a sua caixa de e-mail para receber a chave do produto!";
                    }
                    catch (Exception Ex)
                    {
                        lblError.Text = "Ocorreu um erro ao guardarmos o seu e-mail, mas você ainda pode baixar o livro <a href='download.aspx'>aqui</a>. <br/> Menssagem do erro: " + Ex.Message;
                    }

                }
                else
                    lblError.Text = "Seu e-mail ainda não está cadastrado.";
            }
            else
                lblError.Text = "Por favor, insira seu e-mail";
        }
    }
}