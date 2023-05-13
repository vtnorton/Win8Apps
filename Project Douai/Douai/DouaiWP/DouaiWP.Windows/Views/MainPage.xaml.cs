using DouaiCore;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DouaiWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ChangeExample();
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
    }
}
