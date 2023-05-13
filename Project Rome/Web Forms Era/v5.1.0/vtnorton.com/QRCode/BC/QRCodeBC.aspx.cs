using Core;
using Core.Methods;
using Core.Shared;
using Core.Shared.Email;
using MoonCore.Methods;
using System;
using System.Net;
using System.Net.Mail;
using System.Web.UI;

namespace VTNORTON.QRCode.BC
{
    public partial class QRCodeBC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtEmail.Attributes.Add("placeholder", Resources.master.srtYouEmail);
            txtMenssagem.Attributes.Add("placeholder", Resources.master.srtYouMenssage);
            txtNome.Attributes.Add("placeholder", Resources.master.srtYouName);
            btnContactInfo.Text = Resources.master.srtSend;
            lblSocialIcons.Text = "<ul><li><a href='" + SharedInformation.URLFacebook + "'><i class='fa fa-facebook'></i></a></li><li><a href='" + SharedInformation.URLTwitter + "'><i class='fa fa-twitter'></i></a></li><li><a href='" + SharedInformation.URLInstagram + "'><i class='fa fa-instagram'></i></a></li><li><a href='" + SharedInformation.URLGitHub + "'><i class='fa fa-github'></i></a></li><li><a href='" + SharedInformation.URLYoutube + "'><i class='fa fa-youtube'></i></a></li></ul><p><br /><div class='copyright text-center'><p>" + Resources.master.srtVersionSite + Core.Version.Vtnorton + " | " + Resources.master.srtVersionCore + Core.Version.Core + " </p><p>" + Resources.master.srtFooter + "</p><p><a href='#?lang=pt'>Site em português</a> | <a href='#?lang=en'>Site in English</a></p></div>";
        }
        protected void btnContactInfo_Click(object sender, EventArgs e)
        {

            SmtpClient Cliente = new SmtpClient();
            MailMessage Message = new MailMessage();
            try
            {
                Cliente.Host = JadeAccount.Host;
                Cliente.Port = JadeAccount.Port;
                Cliente.UseDefaultCredentials = JadeAccount.UseDefaultCredentials;
                Cliente.Credentials = new NetworkCredential(JadeAccount.Email, JadeAccount.Password);
                Cliente.EnableSsl = JadeAccount.EnableSsl;
                Message.IsBodyHtml = JadeAccount.IsBodyHtml;
                Message.Subject = "CONTATO de: " + txtNome.Text;
                Message.Body = string.Concat(Core.Shared.Email.Body.Portuguese.Main.Start, Strings.FistUppercaseAllWords(txtNome.Text), "<br />E-mail: ", txtEmail.Text, "<br /><br /><br />Mensagem: ", txtMenssagem.Text, Core.Shared.Email.Body.Portuguese.Main.End);
                Message.From = new MailAddress(JadeAccount.From);
                Message.To.Add(new MailAddress(JadeAccount.From));
                Cliente.Send(Message);
                txtNome.Text = null;
                txtMenssagem.Text = null;
                txtEmail.Text = null;
                lblInfoContatct.Text = "<div>" + Resources.master.srtThanks + " ;)</div>";
                Page.MaintainScrollPositionOnPostBack = true;
                this.ClientScript.RegisterStartupScript(this.GetType(), "navigate", "document.getElementById('footer').scrollIntoView();", true);
            }
            catch (Exception ex)
            {
                Create bug = new Create();
                bug.NewBug("Não recebido", "jade@vtnorton.com", "Erro ao enviar mensagem em index.aspx." + ex.Message, "vtnorton.com");
                lblInfoContatct.Text = "<div>" + Resources.master.srtFailToSend + " :-(</div>";
            }
        }
    }
}