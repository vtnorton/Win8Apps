using System;
using VTNORTON.Core;

namespace VTNORTON.onenote
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLCommands sqlCommands = new SQLCommands();
                if((txtEmail.Text != null) || (txtEmail.Text != ""))
                {
                    sqlCommands.SQLCommand("INSERT INTO tbl_onenoteemails (Email) VALUES ('" + txtEmail.Text + "')");
                    Response.Redirect("/onenote/download.aspx");
                }
                else
                {
                    Label1.Text = "Por favor, insira seu e-mail";
                }
            }
            catch (Exception Ex)
            {
                Label1.Text = "Ocorreu um erro ao guardarmos o seu e-mail, mas você ainda pode baixar o livro <a href='download.aspx'>aqui</a>. <br/> Menssagem do erro: " + Ex.Message;
            }
        }
    }
}