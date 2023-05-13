using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core.CRUD.Temas
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read _read = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptIndex.DataSource = _read.Temas();
                    rptIndex.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }
                if (rptIndex.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum dado no momento. Adicione um!</p></div>";
            }
        }
        protected void delete_Command(object sender, CommandEventArgs e)
        {
            Delete delete = new Delete();
            try
            {
                delete.DeleteTema(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/Core/CRUD/Temas/index.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "<div class='about-content erro text-center'><p>Erro ao deletar: " + ex.Message + "</p></div>";
            }
        }
    }
}