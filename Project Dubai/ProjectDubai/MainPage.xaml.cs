using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectDubai
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            frameContent.NavigationCompleted += FrameContent_NavigationCompleted;
            OpenSarahah();
        }

        private void btnMenssage_Click(object sender, RoutedEventArgs e)
        {
            OpenSarahah();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            OpenSarahah();
        }

        private void OpenSarahah()
        {
            frameContent.Navigate(new Uri("http://sarahah.com/Messages"));
        }

        private async void FrameContent_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            string script = @"$('nav').remove();
                              $('footer').remove();
                              $('.nav-pills.small li a').css('padding', '15px');
                              $('.nav-pills.small li a').css('font-size', '15px');
                              $('a img').css('display', 'none');
                              $('.panel').css('margin-top', '-30px');
                              var script = document.createElement('script');
                              script.type = 'text/javascript';
                              script.src = 'https://pagead2.googlesyndication.com/pagead/js/adsbygoogle.js';
                              $('.panel').append(script);
                              $('.panel').append('<ins class=""adsbygoogle"" style=""display:block"" data-ad-client=""ca-pub-5584056449430370"" data-ad-slot=""2250583777"" data-ad-format=""auto""></ins>');
                              (adsbygoogle = window.adsbygoogle || []).push({ });";

            await frameContent.InvokeScriptAsync("eval", new string[] { script });
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                frameContent.Navigate(new Uri("http://sarahah.com/Manage"));
            }
            catch (Exception)
            {

            }
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }
    }
}
