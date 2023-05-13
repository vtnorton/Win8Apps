using AllVtnorton.Email;
using AllVtnorton.Email.Portuguese;
using BSharp.Methods;
using Ladon.Methods;
using System;
using System.Net;
using System.Net.Mail;

namespace HidraOnline.p
{
    public partial class Bug : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnivar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != null)
            {
                if (txtDescricao.Text != null)
                {
                    Read bug = new Read();
                    Create newBug = new Create();
                    bool Worked = newBug.NewBug("Não recebido", txtEmail.Text, txtDescricao.Text, "hidra.vtnorton.com");
                    if (Worked)
                    {
                        if (!ckbNaoEmail.Checked)
                        {
                            SmtpClient Cliente = new SmtpClient();
                            MailMessage Message = new MailMessage();
                            NetworkCredential smtpCreds = new NetworkCredential(JadeAccount.Email, JadeAccount.Password);
                            Cliente.Host = JadeAccount.Host;
                            Cliente.Port = JadeAccount.Port;
                            Cliente.UseDefaultCredentials = JadeAccount.UseDefaultCredentials;
                            Cliente.Credentials = smtpCreds;
                            Cliente.EnableSsl = JadeAccount.EnableSsl;
                            Message.IsBodyHtml = JadeAccount.IsBodyHtml;
                            Message.Body = string.Concat(BodyPt.StartSendFoward, "<br />E-mail: ", txtEmail.Text, "<br /><br /><br />Mensagem: ", Strings.JustFistUppercase(txtDescricao.Text), BodyPt.End);
                            Message.Subject = "Relatório de bug Hidra OS: Code #" + bug.BugLastId().ToString();
                            Message.From = new MailAddress(txtEmail.Text);
                            Message.To.Add(new MailAddress(txtEmail.Text));
                            Cliente.Send(Message);
                        }
                        txtDescricao.Text = null;
                        lblInfo.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p> Seu relatório foi enviado com sucesso, estarei analizando e em breve você receberá uma resposta sobre este erro.</p></div>";
                    }
                    else
                    {
                        lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p>Houve um erro desconhecido ao enviar seu pedido de analise, por favor, entre em contato com o administrador do sistema para mais informações.</p></div>";
                    }
                }
                else
                {
                    lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p> Por favor, insira a descrição do problema.</p></div>";
                }
            }
            else
            {
                lblInfo.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p> Para que você acompanhe o andamento da correção do bug, é necessário que me informe seu e-mail.</p></div>";
            }
        }
    }
}