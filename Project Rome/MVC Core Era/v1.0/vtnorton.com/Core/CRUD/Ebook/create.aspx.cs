using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Ebook
{
    public partial class create : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            vtnCore.Classes.Ebook obj = new vtnCore.Classes.Ebook();
            EbookRepository repo = new EbookRepository();

            obj.Descricao = txtDescricao.Text;
            obj.Downloads = 0;
            obj.Name = txtNome.Text;

            try
            {
                repo.Create(obj);
                lblInfo.Text = "<div class='about-content text-center'><p>Dados cadastrados com sucesso</p></div>";
                txtDescricao.Text = null;
                txtNome.Text = null;
            }
            catch (Exception ex)
            {
                lblInfo.Text = "<div class='about-content erro text-center'><p>Houve um erro. Detalhes: " + ex.Message + "</p></div>";
            }
        }
    }
}