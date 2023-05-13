using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class zero_css : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            TemaRepository repo = new TemaRepository();

            if (!IsPostBack)
                lblConteudo.Text = repo.RetornarID(Id).Conteudo;
        }
    }
}