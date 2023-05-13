using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Ebook
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
            vtnCore.Classes.Ebook obj = new vtnCore.Classes.Ebook();
            EbookRepository repo = new EbookRepository();

            obj.Id = Id;
            obj.Descricao = txtDescricao.Text;
            obj.Downloads = repo.RetornarID(Id).Downloads;
            obj.Name = txtNome.Text;

            repo.Update(obj);
        }
    }
}