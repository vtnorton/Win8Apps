using DouaiCore.Code;
using DouaiWP.Code;
using System;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiWP.Views
{
    public sealed partial class About : Page
    {
        public About()
        {
            this.InitializeComponent();
            txtVersion.Text = "Versão do aplicativo: 3.1703.53";
        }

        private void HyperlinkButton_Click_1(object sender, RoutedEventArgs e)
        {
            RateApp.RateThisApp();
        }

        private async void Image_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri(@"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=QGYKJP6DMW7C4"));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private async void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(Information.DownloadWin8FullApp);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private async void btnComprarAppBar_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(Information.DownloadWin8FullApp);
        }
    }
}
