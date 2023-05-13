using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using AllVtnorton.Email;
using AllVtnorton.Email.Portuguese;
using System.Net;
using Ladon.Methods;
using BSharp.Methods;

namespace VTNORTON
{
    public partial class report : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtInvalidSpam.Text != null)
            {
                if (txtEmail.Text != null)
                {
                    if (txtMensagem.Text != null)
                    {
                        Read bug = new Read();
                        Ladon.Methods.Create newBug = new Ladon.Methods.Create();
                        bool Worked = newBug.NewBug("NonRecived", txtEmail.Text, txtMensagem.Text, "vtnorton.com");
                        if (Worked)
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
                            Message.Body = string.Concat(BodyPt.StartSendFoward, "<br />E-mail: ", txtEmail.Text, "<br /><br /><br />Mensagem: ", Strings.FistUppercase(txtMensagem.Text), BodyPt.End);
                            Message.Subject = "Relatório de bug vtnorton.com: Code #" + bug.BugLastId().ToString();
                            Message.From = new MailAddress(txtEmail.Text);
                            Message.To.Add(new MailAddress(txtEmail.Text));
                            Cliente.Send(Message);
                            txtEmail.Text = null;
                            txtMensagem.Text = null;
                            lblTexto.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p> Seu relatório foi enviado com sucesso, estarei analizando e em breve você receberá uma resposta sobre este erro.</p></div>";
                        }
                        else
                        {
                            lblTexto.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p>Houve um erro desconhecido ao enviar seu pedido de analise, por favor, entre em contato com o administrador do sistema para mais informações.</p></div>";
                        }
                    }
                    else
                    {
                        lblTexto.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p> Por favor, insira a descrição do problema.</p></div>";
                    }
                }
                else
                {
                    lblTexto.Text = "<div class='info'><h1 class='red'>Erro!</h1><hr /><p> Para que você acompanhe o andamento da correção do bug, é necessário que me informe seu e-mail.</p></div>";
                }
            }
            else
            {
                lblTexto.Text = "<div class='info'><h1 class='red'>SPAMER! :-)</h1><hr /><p>Aqui você não tem vez! <br /> Se você recebeu essa mensagem por engano, tente reenviar o formulario de contato. Pedimos desculpas por isso.</p></div>";
            }
        }
    }
}