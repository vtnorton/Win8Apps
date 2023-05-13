using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core
{
    public partial class email : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readEmail = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptEvento.DataSource = readEmail.Email();
                    rptEvento.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                if (rptEvento.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum email no momento</p></div>";

            }

        }
        protected void delete_Command(object sender, CommandEventArgs e)
        {
            Delete deleteEmail = new Delete();
            try
            {
                deleteEmail.DeleteEmail(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/Core/email.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar email: " + ex.Message;
            }
        }
    }
}