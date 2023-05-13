using System;
using System.Web.UI;
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
    }
}