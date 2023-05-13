using ProjectQuebec.Fluent.UICode.ListViews;
using Windows.UI.Xaml.Controls;

namespace ProjectQuebec.Fluent.Sidebar
{
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
            ListOptions.ItemsSource = SettingsOptions.GetMainItems();
        }

        private void ListOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            SettingsOptions settings = e.ClickedItem as SettingsOptions;
            Frame.Navigate(settings.PageType);
        }
    }
}
