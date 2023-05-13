using System;
using System.Web.UI;
using vtnCore.Methods;

namespace VTNORTON.Core.eBook
{
    public partial class manage_ebook : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readEbook = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptClient.DataSource = readEbook.Ebooks();
                    rptClient.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                if (rptClient.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum eBook no momento. Adicione um!</p></div>";

            }
        }
    }
}