using System;
using System.Web.UI.WebControls;
using vtnCore.Methods;

namespace VTNORTON.Core.eBook
{
    public partial class view_ebook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Read readOneNote = new Read();

            if (!IsPostBack)
            {
                try
                {
                    rptClient.DataSource = readOneNote.OneNoteEmails();
                    rptClient.DataBind();
                }
                catch (Exception E)
                {
                    lblErro.Text = "<div class='about-content text-center'><p>Houve um erro. Detalhes: " + E.Message + "</p></div>";
                }

                if (rptClient.Items.Count == 0)
                    lblErro.Text = "<div class='about-content text-center'><p>Não foi encontrado nenhum email no momento. Adicione um!</p></div>";

            }
        }

        protected void delete_Command(object sender, CommandEventArgs e)
        {
            Delete deleteOneNote = new Delete();
            try
            {
                deleteOneNote.DeleteOneNote(int.Parse(e.CommandArgument.ToString()));
                Response.Redirect("/Core/eBook/view-ebook-onenote.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao deletar OneNote: " + ex.Message;
            }
        }
    }
}