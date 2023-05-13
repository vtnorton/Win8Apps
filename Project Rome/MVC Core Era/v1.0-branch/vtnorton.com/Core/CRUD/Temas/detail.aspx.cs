using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class detail : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            TemaRepository repo = new TemaRepository();

            lblNome.Text = repo.RetornarID(Id).Nome;
            lblDescricao.Text = repo.RetornarID(Id).Descricao;
            lblTema.Text = repo.RetornarID(Id).Conteudo;

        }
    }
}