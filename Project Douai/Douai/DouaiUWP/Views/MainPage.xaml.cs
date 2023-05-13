using DouaiCore;
using DouaiUWP.Code;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DouaiUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ChangeExample();
            if (GerenciadorDePacotes.HasPackForAds())
            {
                Ad.Visibility = Visibility.Collapsed;
            }
        }

        private async void ChangeExample()
        {
            Exemplo.Text = Samples.SortearExemplo();
            await Task.Delay(5000);
            ChangeExample();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Conjugar();
        }

        private void Conjugar()
        {
            string verboaenviar = Verbo.Text.ToLower().Trim();
            Frame.Navigate(typeof(Conjugado), verboaenviar);
        }
    }
}
