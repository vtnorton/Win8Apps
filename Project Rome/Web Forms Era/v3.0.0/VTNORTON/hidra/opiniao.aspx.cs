using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON.search
{
    public partial class opiniao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SmtpClient cliente = new SmtpClient();
            MailMessage msg = new MailMessage();
            System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("jade@vtnorton.com", "");
            try
            {
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = smtpCreds;
                cliente.EnableSsl = true;
                string body = string.Concat("Nome: ", txtNome.Text, "\nE-mail: ", txtEmail.Text, "\nMensagem: ", txtMensagem.Text);
                msg.Subject = "Search - de " + txtNome.Text;
                msg.Body = body;
                msg.From = new MailAddress("vitor@vtnorton.com");
                msg.To.Add(new MailAddress("vitor@vtnorton.com"));
                cliente.Send(msg); Label4.Text = "E-mail enviado, com sucesso! Responderemos sua mensagem em breve!";
            }
            catch
            {
                Label4.Text = "Erro ao enviar e-mail, tente denovo! :-( <br /> Isso não deveria ter acontecido, desculpe-me por isso!";
            }
        }
    }
}