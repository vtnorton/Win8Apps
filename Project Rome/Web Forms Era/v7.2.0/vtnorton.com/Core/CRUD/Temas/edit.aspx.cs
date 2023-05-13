using System;
using System.Web.UI;
using vtnCore.Repository;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class edit : Page
    {
        int Id;
        vtnCore.Classes.Temas obj = new vtnCore.Classes.Temas();
        TemaRepository repo = new TemaRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["Id"]);

            if (!IsPostBack)
            {
                txtDescricao.Text = repo.RetornarID(Id).Descricao;
                txtNome.Text = repo.RetornarID(Id).Nome;
                CKEditorControl1.Text = repo.RetornarID(Id).Conteudo;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            obj.Id = Id;
            obj.Descricao = txtDescricao.Text;
            obj.Nome = txtNome.Text;
            obj.Conteudo = CKEditorControl1.Text;

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