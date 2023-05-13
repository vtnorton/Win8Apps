using DouaiUWP.Data;
using DouaiUWP.ViewModels;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace DouaiUWP.Views
{
    public sealed partial class ChangelogDetails : Page
    {
        public ChangelogDetails()
        {
            this.InitializeComponent();
        }
        public static DependencyProperty ItemProperty
        {
            get { return s_itemProperty; }
        }
        public HistoryVersionViewModel Item
        {
            get { return (HistoryVersionViewModel)GetValue(s_itemProperty); }
            set { SetValue(s_itemProperty, value); }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Item = HistoryVersionViewModel.FromItem(HistoryVersionDataSource.GetHistoryVersionById((int)e.Parameter));
            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested += DetailPage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            SystemNavigationManager systemNavigationManager = SystemNavigationManager.GetForCurrentView();
            systemNavigationManager.BackRequested -= DetailPage_BackRequested;
            systemNavigationManager.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }
        private void OnBackRequested()
        {
            Frame.GoBack(new DrillInNavigationTransitionInfo());
        }
        private void PageRoot_Loaded(object sender, RoutedEventArgs e)
        {
            FindName("RootPanel");
            Window.Current.SizeChanged += Window_SizeChanged;
        }
        private void PageRoot_Unloaded(object sender, RoutedEventArgs e)
        {
            Window.Current.SizeChanged -= Window_SizeChanged;
        }
        private void Window_SizeChanged(object sender, WindowSizeChangedEventArgs e)
        {

        }
        private void DetailPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            e.Handled = true;
            OnBackRequested();
        }
        private static DependencyProperty s_itemProperty = DependencyProperty.Register("HistoryVerion", typeof(HistoryVersionViewModel), typeof(ChangelogDetails), new PropertyMetadata(null));
    }
}
