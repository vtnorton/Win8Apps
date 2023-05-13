using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class view : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);

            TheIframe.Src = "zero-css.aspx?Id=" + Id;

            TemaRepository repo = new TemaRepository();

            if (!IsPostBack)
            {
                lblDescricao.Text = repo.RetornarID(Id).Descricao;
                lblNome.Text = repo.RetornarID(Id).Nome;
                lblNewPage.Text = "<a href='zero-css.aspx?Id=" + Id + "' target='_blank'>Sim</a>";
            }
        }
    }
}