using DouaiCore;
using DouaiCore.Code;
using System;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ChangeExample();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private async void ChangeExample()
        {
            Exemplo.Text = Samples.SortearExemplo();
            await Task.Delay(5000);
            ChangeExample();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Conjugado), Verbo.Text.ToLower().Trim());
        }

        private async void btnComprar_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(Information.DownloadWin8FullApp);
        }

        private async void btnComprarAppBar_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(Information.DownloadWin8FullApp);
        }

        private void btnHelp_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
    }
}
