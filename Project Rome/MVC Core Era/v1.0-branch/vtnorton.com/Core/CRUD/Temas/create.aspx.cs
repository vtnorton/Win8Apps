using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class create : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            vtnCore.Classes.Temas obj = new vtnCore.Classes.Temas();
            TemaRepository repo = new TemaRepository();

            obj.Descricao = txtDescricao.Text;
            obj.Nome = txtNome.Text;
            obj.Conteudo = CKEditorControl1.Text;

            repo.Create(obj);
        }
    }
}