using Microsoft.Toolkit.Uwp.UI.Controls;
using ProjectQuebec.Code.FileHandle;
using ProjectQuebec.Code.Util;
using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ProjectQuebec.Fluent.Sidebar
{
    public sealed partial class TabsView : Page
    {
        FileInteraction fileInteraction = new FileInteraction();
        public TabsView()
        {
            this.InitializeComponent();

            TabsListView.ItemsSource = FileOpend.AllFilesList;

            if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    TabsListView.Background = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMain70"] as SolidColorBrush).Color,
                        TintOpacity = 0.9
                    };
                }
                catch (Exception)
                {
                    TabsListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                }

            }
            else
            {
                TabsListView.Background = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Helpers._openPage.Add(typeof(NewFile));
        }

        private async void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            await fileInteraction.OpenFile();
            Frame.Navigate(typeof(Editor), FileOpend.GetLastAddedFile());
        }

        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.SaveAllFiles();
        }

        private void TabsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            FileObject fileToOpen = e.ClickedItem as FileObject;
            Frame.Navigate(typeof(Editor), fileToOpen);
        }

        private void SlidableListItem_SwipeStatusChanged(SlidableListItem sender, Microsoft.Toolkit.Uwp.UI.Controls.SwipeStatusChangedEventArgs args)
        {
            var file = (FileObject)sender.DataContext;
            if (args.NewValue == SwipeStatus.Idle)
            {
                if (args.OldValue == SwipeStatus.SwipingPassedLeftThreshold)
                    FileOpend.AllFilesList.Remove(file);
            }
        }

        private void btnCloseAll_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.CloseAllFiles();
            fileInteraction.CloseAllFiles();
        }

        private void btnWelcomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(WelcomePage));
        }
    }
}
