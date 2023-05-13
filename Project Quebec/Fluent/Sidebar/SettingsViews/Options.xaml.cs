using ProjectQuebec.Code.Settings;
using ProjectQuebec.Code.ViewModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProjectQuebec.Fluent.Sidebar.SettingsView
{
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }

        private void btnCleanRecentList_Click(object sender, RoutedEventArgs e)
        {
            RecentListViewModel.RemoveAll();
        }

        private void btnRestoreDefault_Click(object sender, RoutedEventArgs e)
        {
            DefaultSettings.RestoreDefaultSettings();
        }       

        private void btnRestoreSettings_Click(object sender, RoutedEventArgs e)
        {
            ImportExport.ImportToJson();
        }

        private void btnExportSettings_Click(object sender, RoutedEventArgs e)
        {
            ImportExport.ExportToJson();
        }

        private void btnFormulaSchool_Toggled(object sender, RoutedEventArgs e)
        {
        }

        private void cbbAppLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplicationData.Current.LocalSettings.Values["language"] = (sender as ComboBox).SelectedIndex.ToString();
        }

        private void cbbZoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplicationData.Current.LocalSettings.Values["zoom"] = (sender as ComboBox).SelectedItem;
        }

        private void txtToDo_LostFocus(object sender, RoutedEventArgs e)
        {
            ApplicationData.Current.LocalSettings.Values["todo"] = (sender as TextBox).Text;
        }
    }
}
