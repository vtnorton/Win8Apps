using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core.CRUD.Enviados
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read _read = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptIndex.DataSource = _read.Enviados();
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