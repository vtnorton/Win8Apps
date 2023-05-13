using Microsoft.Graphics.Canvas.Text;
using ProjectQuebec.Code.Settings;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectQuebec.Fluent.Sidebar.SettingsView
{
    public sealed partial class Personalization : Page
    {
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        public Personalization()
        {
            this.InitializeComponent();

            if (localSettings.Values["theme"] != null)
            {
                if (localSettings.Values["theme"].ToString() == "light")
                    btnLight.IsChecked = true;
                else
                    btnDark.IsChecked = true;
            }
            else
            {
                btnDefault.IsChecked = true;
            }

            cbbFontSize.ItemsSource = SettingsUtil.FontSizes;
            cbbFontFamily.ItemsSource = SettingsUtil.FontNames;

            if (localSettings.Values["font"] == null)
                cbbFontFamily.SelectedItem = "Consolas";
            else
                cbbFontFamily.SelectedItem = localSettings.Values["font"];

            if (localSettings.Values["font-size"] == null)
                cbbFontSize.SelectedItem = 14;
            else
                cbbFontSize.SelectedItem = int.Parse(localSettings.Values["font-size"].ToString());
        }

        private void ThemeSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            btnDark.IsChecked = false;
            btnDefault.IsChecked = false;
            btnLight.IsChecked = false;
            
            string content = (sender as RadioButton).Content.ToString();
            if(content == "Dark Mode")
            {
                RequestedTheme = ElementTheme.Dark;
                localSettings.Values["theme"] = "dark";
                btnDark.IsChecked = true;
            }
            else if(content == "Light Mode")
            {
                RequestedTheme = ElementTheme.Light;
                localSettings.Values["theme"] = "light";
                btnLight.IsChecked = true;
            }
            else
            {
                RequestedTheme = ElementTheme.Default;
                localSettings.Values["theme"] = null;
                btnDefault.IsChecked = true;
            }

            txtRestart.Visibility = Visibility.Visible;
        }

        private void cbbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            localSettings.Values["font"] = (sender as ComboBox).SelectedItem.ToString();
        }

        private void cbbFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            localSettings.Values["font-size"] = (sender as ComboBox).SelectedItem.ToString();
        }
    }
}
