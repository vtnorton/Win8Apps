using System.Text.RegularExpressions;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProjectRedmonde.Views
{
    public sealed partial class SendFeedback : Page
    {
        public SendFeedback()
        {
            this.InitializeComponent();
        }

        private void btnSend_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ///TODO: Trazudir para o Inglês
            int counter = 0;
            string text;
            txtMenssage.Document.GetText(Windows.UI.Text.TextGetOptions.None, out text);
            lblMenssage.Foreground = new SolidColorBrush(Colors.Red);

            text = new Regex("\\r").Replace(text, "<br />");

            if (txtSubject.Text == null || txtSubject.Text == "")
            {
                lblMenssage.Text = "Por favor, escreva um assunto.";
                counter++;
            }
            else
            {
                if (text == null || text == "")
                {
                    lblMenssage.Text = "Por favor, escreva sua mensage.";
                    counter++;
                }
                else
                {
                    if (txtEmail.Text == null || txtEmail.Text == "")
                    {
                        if (counter < 2)
                            lblMenssage.Text = "Você precisa escrever seu e-mail, não irei mandar spam!";
                        else
                            lblMenssage.Text = "Qualé, você já não escreveu a mensage, o assunto e agora quer enviar um feedback só com e-mail? Sem chance!";
                    }
                    else
                    {
                        try
                        {
                            ///TODO: Add Webservice
                            //SendFeedbackMenssageService.FeedbackSoapClient sendFeedback = new SendFeedbackMenssageService.FeedbackSoapClient();
                            //sendFeedback.SendFeedbackEmailAsync("Project Douai", text, txtEmail.Text, txtSubject.Text);
                            lblMenssage.Foreground = new SolidColorBrush(Colors.White);
                            lblMenssage.Text = "Feedback enviado com sucesso, obrigado!";
                            txtEmail.Text = "";
                            text = "";
                            txtSubject.Text = "";
                        }
                        catch
                        {
                            lblMenssage.Text = "Houve um problema ao enviar seu feedback. Tente mandar para o e-mail contato@vtnorton.com.";
                        }
                    }
                }
            }
        }
    }
}
