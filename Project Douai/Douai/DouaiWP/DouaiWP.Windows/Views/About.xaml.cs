using DouaiCore.Code;
using DouaiWP.Code;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DouaiWP.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            txtVersion.Text = "Versão do aplicativo: " + Information.VersionWin10;
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private async void Image_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(@"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=QGYKJP6DMW7C4"));
        }
    }
}
