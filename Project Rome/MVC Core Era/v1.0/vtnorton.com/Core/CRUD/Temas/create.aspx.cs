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

            try
            {
                repo.Create(obj);
                lblInfo.Text = "<div class='about-content text-center'><p>Dados cadastrados com sucesso</p></div>";
                txtDescricao.Text = null;
                txtNome.Text = null;
                CKEditorControl1.Text = null;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "<div class='about-content erro text-center'><p>Houve um erro. Detalhes: " + ex.Message + "</p></div>";
            }
        }
    }
}