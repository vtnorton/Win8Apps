using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core.CRUD.Listas
{
    public partial class emails_cadastrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            Read _read = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptIndex.DataSource = _read.Email(Id);
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
                delete.DeleteEmail(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/Core/CRUD/Listas/emails-cadastrados.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar: " + ex.Message;
            }
        }
    }
}