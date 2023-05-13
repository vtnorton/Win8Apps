using System;
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
            objMail.IdLista = Id;
            objMail.Mail = txtEmail.Text;
            objMail.Data = DateTime.Now;
            repoEmail.Create(objMail);
        }
    }
}