using System;
using vtnCore.Classes;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Listas
{
    public partial class create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ListaEmails obj = new ListaEmails();
            ListaEmailsRepository repo = new ListaEmailsRepository();

            obj.Descricao = txtDescricao.Text;
            obj.Inscritos = 0;
            obj.Titulo = txtTitulo.Text;
            obj.FooterMenssage = txtFooter.Text;

            repo.Create(obj);
        }
    }
}