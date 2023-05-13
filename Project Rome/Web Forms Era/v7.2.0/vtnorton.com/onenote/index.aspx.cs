using System;
using System.ComponentModel.DataAnnotations;
using vtnCore;
using vtnCore.Classes;
using vtnCore.Methods;
using vtnCore.Repository;
using vtnCore.Stuff;

namespace VTNORTON.onenote
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    InsertEmail.Insert(txtEmail.Text, EmailLists.OneNote);

                    Response.Redirect("/onenote/gdon.aspx");
                }
                else
                    Label1.Text = "Por favor, insira seu e-mail";
            }
            catch (Exception Ex)
            {
                Label1.Text = "Ocorreu um erro ao guardarmos o seu e-mail, mas você ainda pode baixar o livro <a href='download.aspx'>aqui</a>. <br/> Menssagem do erro: " + Ex.Message;
            }
        }
    }
}