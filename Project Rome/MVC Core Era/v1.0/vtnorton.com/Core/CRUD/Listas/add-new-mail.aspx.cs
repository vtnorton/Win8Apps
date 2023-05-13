using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI;
using vtnCore.Classes;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Listas
{
    public partial class add_new_mail : Page
    {
        vtnCore.Classes.Email objMail = new vtnCore.Classes.Email();
        ListaEmailsRepository repo = new ListaEmailsRepository();
        EmailRepository repoEmail = new EmailRepository();
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["Id"]);

            lblLista.Text = repo.RetornarID(Id).Titulo;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool everythingSubmited = true;
            string notSubmited = @"Os seguintes e-mails não foram enviados: <br />";
            try
            {
                objMail.IdLista = Id;
                objMail.Data = DateTime.Now;

                if (string.IsNullOrEmpty(txtEmail.Text)){
                    string[] lines = txtEmailMultiplos.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (var line in lines)
                    {
                        if (new EmailAddressAttribute().IsValid(line))
                        {
                            objMail.Mail = line;
                            repoEmail.Create(objMail);
                        }
                        else
                        {
                            everythingSubmited = false;
                            notSubmited += line + @"<br/>";
                        }   
                    }
                }
                else if (string.IsNullOrEmpty(txtEmailMultiplos.Text))
                {
                    if (new EmailAddressAttribute().IsValid(txtEmail.Text))
                    {
                        objMail.Mail = txtEmail.Text;
                        repoEmail.Create(objMail);
                    }
                }
                else
                {

                }

                txtEmailMultiplos.Text = null;
                txtEmail.Text = null;
                if (everythingSubmited)
                    lblInfo.Text = "Todos os e-mails foram cadastrados com sucesso!";
                else
                    lblInfo.Text = notSubmited;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Houve um erro ao cadastrar um e-mail: " + ex.Message;
                throw;
            }
        }
    }
}