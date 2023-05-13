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

namespace HidraOnline.p
{
    public partial class email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SmtpClient Cliente = new SmtpClient();
            MailMessage Message = new MailMessage();
            NetworkCredential smtpCreds;

            if (ddlFrom.Text == "ddlVitorAccount")
            {
                smtpCreds = new NetworkCredential(VitorAccount.Email, VitorAccount.Password);
            }
            else if (ddlFrom.Text == "ddlJadeAccount")
            {
                smtpCreds = new NetworkCredential(JadeAccount.Email, JadeAccount.Password);
            }
            else
            {
                smtpCreds = new NetworkCredential(ContactAccount.Email, ContactAccount.Password);
            }

            if (txtInvalidSpam.Text != null)
            {
                try
                {
                    Cliente.Host = VitorAccount.Host;
                    Cliente.Port = VitorAccount.Port;
                    Cliente.UseDefaultCredentials = VitorAccount.UseDefaultCredentials;
                    Cliente.Credentials = smtpCreds;
                    Cliente.EnableSsl = VitorAccount.EnableSsl;
                    Message.IsBodyHtml = VitorAccount.IsBodyHtml;
                    if (ddlLanguageEmail.Text == "pt-br")
                    {
                        if (cbxHeader.Checked)
                        {
                            Message.Body = string.Concat(BodyPt.Start, Strings.FistUppercase(CKEditor1.Text).Trim(), BodyPt.EndForSenddingEmail);
                        }
                        else
                        {
                            Message.Body = string.Concat(BodyPt.StartForSenddingEmail, Strings.FistUppercase(CKEditor1.Text).Trim(), BodyPt.EndForSenddingEmail);
                        }
                    }
                    else
                    {
                        if (cbxHeader.Checked)
                        {
                            Message.Body = string.Concat(BodyEn.Start, Strings.FistUppercase(CKEditor1.Text), BodyEn.EndForSenddingEmail);
                        }
                        else
                        {
                            Message.Body = string.Concat(BodyEn.StartForSenddingEmail, Strings.FistUppercase(CKEditor1.Text), BodyEn.EndForSenddingEmail);
                        }
                    }
                    Message.From = new MailAddress(txtEmail.Text);
                    Message.To.Add(new MailAddress(txtEmail.Text));
                    if (txtSubject.Text != null)
                    {
                        Message.Subject = Strings.FistUppercase(txtSubject.Text);
                        Cliente.Send(Message);
                        txtSubject.Text = null;
                        CKEditor1.Text = null;
                        txtEmail.Text = null;
                        Label4.Text = "<div class='info'><h1>Sucesso!</h1><hr /><p> Seu e-mail foi enviado com sucesso. <br /></p></div>";
                    }
                    else
                    {
                        Label4.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p>Você precisa incluir um assunto na sua mensagem!</p></div>";
                    }
                }
                catch
                {
                    Label4.Text = "<div class='info'><h1 class='red'>Erro! :-(</h1><hr /><p> Infelizmente seu e-mail foi não foi enviado. <br /> Entre em contato com o administrador para poder atualizar o seu sistema. <br /> Isso não deveria ter acontecido.</div></p>";
                }
            }
            else
            {
                Label4.Text = "<div class='info'><h1 class='red'>SPAMER! :-)</h1><hr /><p>Aqui você não tem vez! <br /> Se você recebeu essa mensagem por engano, tente reenviar o formulario de contato. Pedimos desculpas por isso.</p></div>";
            }
        }
    }
}