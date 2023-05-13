using ProjectMontreal.Code;
using System;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectMontreal
{
    public sealed partial class MainPage : Page
    {
        private bool isCtrlKeyPressed = false;
        private FileInteraction fileInteraction = new FileInteraction();
        public MainPage()
        {
            this.InitializeComponent();

            if (ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    AcrylicBrush ShellColor = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColor60"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColor60"] as SolidColorBrush).Color,
                        TintOpacity = 0.6
                    };

                    AcrylicBrush RecentFilesColor = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColor80"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColor80"] as SolidColorBrush).Color,
                        TintOpacity = 0.8
                    };

                    gridShell.Background = ShellColor;
                    gridRecentFiles.Background = RecentFilesColor;
                }
                catch (Exception)
                {
                    gridShell.Background = Application.Current.Resources["rsColor60"] as SolidColorBrush;
                    gridRecentFiles.Background = Application.Current.Resources["rsColor80"] as SolidColorBrush;
                }
            }
            else
            {
                gridShell.Background = Application.Current.Resources["rsColor60"] as SolidColorBrush;
                gridRecentFiles.Background = Application.Current.Resources["rsColor80"] as SolidColorBrush;
            }

            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            this.KeyDown += Editor_KeyDown;
            this.KeyUp += Editor_KeyUp;
        }

        #region INTERACTIONS
        private void btnNew_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            fileInteraction.SaveFile(txtContent.Text);
        }
        private async void btnSaveAs_Click(object sender, RoutedEventArgs e)
        {
            await fileInteraction.SaveAsFile(txtContent.Text);
        }
        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        private void Editor_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Control) isCtrlKeyPressed = true;
            else if (isCtrlKeyPressed)
            {
                switch (e.Key)
                {
                    case VirtualKey.S:
                        fileInteraction.SaveFile(txtContent.Text);
                        break;
                }
            }
        }
        private void Editor_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Control) isCtrlKeyPressed = false;
        }
    }
}
