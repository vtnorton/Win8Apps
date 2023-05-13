using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Classes;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Listas
{
    public partial class edit : Page
    {
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["Id"]);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ListaEmails obj = new ListaEmails();
            ListaEmailsRepository repo = new ListaEmailsRepository();

            obj.Id = Id;
            obj.Descricao = txtDescricao.Text;
            obj.Inscritos = 0;
            obj.Titulo = txtTitulo.Text;
            obj.FooterMenssage = txtFooter.Text;

            repo.Update(obj);
        }
    }
}