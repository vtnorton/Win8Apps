using AllVtnorton.Email;
using AllVtnorton.Email.Portuguese;
using BSharp.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VTNORTON
{
    public partial class FormularioDeContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SmtpClient Cliente = new SmtpClient();
            MailMessage Message = new MailMessage();
            MailMessage MessageToUser = new MailMessage();
            NetworkCredential smtpCreds = new NetworkCredential(JadeAccount.Email, JadeAccount.Password);
            if (txtInvalidSpam.Text != null)
            {
                try
                {
                    Cliente.Host = JadeAccount.Host;
                    Cliente.Port = JadeAccount.Port;
                    Cliente.UseDefaultCredentials = JadeAccount.UseDefaultCredentials;
                    Cliente.Credentials = smtpCreds;
                    Cliente.EnableSsl = JadeAccount.EnableSsl;
                    Message.IsBodyHtml = JadeAccount.IsBodyHtml;
                    MessageToUser.IsBodyHtml = JadeAccount.IsBodyHtml;
                    Message.Subject = "CONTATO de: " + txtNome.Text;
                    MessageToUser.Subject = "Contato com Vítor Norton";
                    Message.Body = string.Concat(BodyPt.Start, Strings.FistUppercaseAllWords(txtNome.Text), "<br />E-mail: ", txtEmail.Text, "<br /><br /><br />Mensagem: ", Strings.JustFistUppercase(txtMensagem.Text), BodyPt.End);
                    MessageToUser.Body = string.Concat(BodyPt.Start, BodyPt.IncludeForUsers, Strings.FistUppercaseAllWords(txtNome.Text), "<br />E-mail: ", txtEmail.Text, "<br /><br /><br />Mensagem: ", Strings.JustFistUppercase(txtMensagem.Text), BodyPt.End);
                    Message.From = new MailAddress(JadeAccount.From);
                    Message.To.Add(new MailAddress(JadeAccount.From));
                    MessageToUser.From = new MailAddress(txtEmail.Text);
                    MessageToUser.To.Add(new MailAddress(txtEmail.Text));
                    if (txtNome.Text != null)
                    {
                        Cliente.Send(MessageToUser);
                        Cliente.Send(Message);
                        txtNome.Text = null;
                        txtMensagem.Text = null;
                        txtEmail.Text = null;
                        Label4.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p>" + Strings.FistUppercaseAllWords(txtNome.Text) + ", seu e-mail foi enviado com sucesso. <br /> Tentarei responder em até 48 horas o seu contato via e-mail</p></div>";
                    }
                    else
                    {
                        Label4.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa inserir o seu nome. Seu nome e seu e-mail não serão compartilhados sem sua autorização.</p></div>";
                    }
                }
                catch
                {
                    Label4.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>" + Strings.FistUppercaseAllWords(txtNome.Text) + ", infelizmente seu e-mail foi não foi enviado. <br /> Tente novamente mais tarde ou envie o e-mail para contato@vtnorton.com. Tentarei responder em até 48 horas o seu contato via e-mail. <br /> Isso não deveria ter acontecido. Resolverei esse problema o mais rapído possível.</div></p>";
                }
            }
            else
            {
                Label4.Text = "<div class='info'><h1 class='red'>SPAMER! :-)</h1><hr /><p>Aqui você não tem vez! <br /> Se você recebeu essa mensagem por engano, tente reenviar o formulario de contato. Pedimos desculpas por isso.</p></div>";
            }
        }
    }
}