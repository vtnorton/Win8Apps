using System;
using System.Web.UI;
using vtnCore.Classes;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Listas
{
    public partial class edit : Page
    {
        int Id;
        ListaEmails obj = new ListaEmails();
        ListaEmailsRepository repo = new ListaEmailsRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["Id"]);

            if (!IsPostBack)
            {
                txtDescricao.Text = repo.RetornarID(Id).Descricao;
                txtFooter.Text = repo.RetornarID(Id).FooterMenssage;
                txtTitulo.Text = repo.RetornarID(Id).Titulo;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            obj.Id = Id;
            obj.Descricao = txtDescricao.Text;
            obj.Inscritos = repo.RetornarID(Id).Inscritos;
            obj.Titulo = txtTitulo.Text;
            obj.FooterMenssage = txtFooter.Text;

            try
            {
                repo.Update(obj);
                lblInfo.Text = "<div class='about-content text-center'><p>Dados atualizados com sucesso</p></div>";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "<div class='about-content erro text-center'><p>Houve um erro. Detalhes: " + ex.Message + "</p></div>";
                throw;
            }
        }
    }
}