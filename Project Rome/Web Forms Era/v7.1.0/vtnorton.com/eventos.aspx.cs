using System;
using System.Web.UI;
using vtnCore.Methods;

namespace VTNORTON
{
    public partial class eventos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    rptEvento.DataSource = new Read().Evento(false);
                    rptEvento.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                try
                {
                    rptEventoPassado.DataSource = new Read().Evento(true);
                    rptEventoPassado.DataBind();
                }
                catch (Exception E)
                {
                    lblErroPassado.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

            }
        }
    }
}