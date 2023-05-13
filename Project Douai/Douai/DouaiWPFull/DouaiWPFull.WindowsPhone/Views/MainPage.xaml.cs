using DouaiCore;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiWPFull.Views
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

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Conjugado), Verbo.Text.ToLower().Trim());
        }

        private void btnHelp_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
    }
}
