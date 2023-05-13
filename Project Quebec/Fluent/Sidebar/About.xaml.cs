using ProjectQuebec.Code;
using ProjectQuebec.Code.Util;
using System;
using System.Text.RegularExpressions;
using Windows.System;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectQuebec.Fluent.Sidebar
{
    public sealed partial class About : Page
    {
        private SolidColorBrush Gray = Application.Current.Resources["rsColorMiddleText"] as SolidColorBrush;
        private SolidColorBrush AccentColor = Application.Current.Resources["SystemControlHighlightAccentBrush"] as SolidColorBrush;

        #region APP
        public About()
        {
            this.InitializeComponent();
            txtVersion.Text = "Version: " + Information.Version();
        }
        #endregion

        #region METHODS
        void GoToChangelogPage()
        {
            CollapseAll();
            gdrChangelog.Visibility = Visibility.Visible;
            btnChangelog.BorderBrush = AccentColor;
            btnChangelog.Foreground = AccentColor;
            frameChangelog.Navigate(typeof(AboutViews.Changelog));
        }
        void CollapseAll()
        {
            gdrChangelog.Visibility = Visibility.Collapsed;
            gdrSendFeedback.Visibility = Visibility.Collapsed;
            gdrAbout.Visibility = Visibility.Collapsed;
            grdNews.Visibility = Visibility.Collapsed;

            btnAbout.BorderBrush = Gray;
            btnAbout.Foreground = Gray;
            btnChangelog.BorderBrush = Gray;
            btnChangelog.Foreground = Gray;
            btnSendFeedback.BorderBrush = Gray;
            btnSendFeedback.Foreground = Gray;
            btnNews.BorderBrush = Gray;
            btnNews.Foreground = Gray;
        }
        #endregion

        #region INTERACTION
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            gdrAbout.Visibility = Visibility.Visible;
            btnAbout.BorderBrush = AccentColor;
            btnAbout.Foreground = AccentColor;
        }
        private void btnChangelog_Click(object sender, RoutedEventArgs e)
        {
            GoToChangelogPage();
        }
        private void btnSendFeedback_Click(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            gdrSendFeedback.Visibility = Visibility.Visible;
            btnSendFeedback.BorderBrush = AccentColor;
            btnSendFeedback.Foreground = AccentColor;
        }
        private void btnNews_Click(object sender, RoutedEventArgs e)
        {
            CollapseAll();
            grdNews.Visibility = Visibility.Visible;
            btnNews.BorderBrush = AccentColor;
            btnNews.Foreground = AccentColor;
            frameNews.Navigate(typeof(AboutViews.News));
        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            GoToChangelogPage();
        }
        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }
        
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            string text;
            txtMenssage.Document.GetText(Windows.UI.Text.TextGetOptions.None, out text);
            lblMenssage.Foreground = new SolidColorBrush(Colors.Red);

            text = new Regex("\\r").Replace(text, "<br />");

            if (txtSubject.Text == null || txtSubject.Text == "")
            {
                lblMenssage.Text = "Please, write a subject";
                counter++;
            }
            else
            {
                if (text == null || text == "")
                {
                    lblMenssage.Text = "Please, write your menssage.";
                    counter++;
                }
                else
                {
                    if (txtEmail.Text == null || txtEmail.Text == "")
                    {
                        if (counter < 2)
                            lblMenssage.Text = "Please you have to write you e-mail, we are not going to spam you!";
                        else
                            lblMenssage.Text = "Come on! You haven't writed the subject, the menssage and now you want to send it without the e-mail adress? Oh hell no! Please type your e-mail adress";
                    }
                    else
                    {
                        try
                        {
                            SendFeedbackMenssageService.FeedbackSoapClient sendFeedback = new SendFeedbackMenssageService.FeedbackSoapClient();
                            sendFeedback.SendFeedbackEmailAsync("Project Quebec", text, txtEmail.Text, txtSubject.Text);
                            lblMenssage.Foreground = Application.Current.Resources["rsColorMiddleText"] as SolidColorBrush;
                            lblMenssage.Text = "Feedback sent with success! ;) Thanks a lot!";
                            txtEmail.Text = "";
                            text = "";
                            txtSubject.Text = "";
                        }
                        catch
                        {
                            lblMenssage.Text = "There was an erro sending your menssage.";
                        }
                    }
                }
            }
        }
        #endregion
    }
}
