using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core.events
{
    public partial class manage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readEvent = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptEvento.DataSource = readEvent.Evento();
                    rptEvento.DataBind();

                    if (rptEvento.Items.Count == 0)
                        lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum evento no momento. Adicione um!</p></div>";
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                

            }
        }
        protected void delete_Command(object sender, CommandEventArgs e)
        {
            Delete deleteEvent = new Delete();
            try
            {
                deleteEvent.DeleteEvento(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/Core/events/manage.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar email: " + ex.Message;
            }
        }
    }
}