using ProjectQuebec.Code.Model;
using ProjectQuebec.Code.Util;
using ProjectQuebec.Code.ViewModel;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProjectQuebec.Fluent.Sidebar.AboutViews
{

    public sealed partial class Changelog : Page
    {
        public Changelog()
        {
            this.InitializeComponent();
            ChangelogListView.ItemsSource = ChangelogViewModel.GetAllChangelog();

            if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    ChangelogListView.Background = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMain70"] as SolidColorBrush).Color,
                        TintOpacity = 0.9
                    };
                }
                catch (System.Exception)
                {
                    ChangelogListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                }
                
            }
            else
            {
                ChangelogListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
            }
        }

        private void ChangelogListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangelogModel item = (ChangelogModel)e.ClickedItem;
            Helpers._openChangelog.Add(item);

            if (((Frame)Window.Current.Content).ActualWidth < 700 || DeviceTypeHelper.GetDeviceFormFactorType() == DeviceFormFactorType.Phone)
                Helpers._openPageWithAttribute.Add(new object[] { typeof(ChangelogDetails), item});
                //Frame.Navigate(typeof(ChangelogDetails), item);
        }
    }
}
