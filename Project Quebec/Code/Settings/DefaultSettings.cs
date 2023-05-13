using ProjectQuebec.Code.ViewModel;
using System.Globalization;
using Windows.Globalization;
using Windows.Storage;

namespace ProjectQuebec.Code.Settings
{
    public class DefaultSettings
    {
        public static void RestoreDefaultSettings()
        {
            ApplicationData.Current.LocalSettings.Values["font"] = "Consolas";
            ApplicationData.Current.LocalSettings.Values["font-size"] = "14";
            ApplicationData.Current.LocalSettings.Values["formula4schools"] = true;
            ApplicationData.Current.LocalSettings.Values["language"] = null;
            ApplicationData.Current.LocalSettings.Values["theme"] = null;
            ApplicationData.Current.LocalSettings.Values["todo"] = null;
            ApplicationData.Current.LocalSettings.Values["zoom"] = 3;

            ApplicationLanguages.PrimaryLanguageOverride = CultureInfo.CurrentUICulture.Name;
            RecentListViewModel.RemoveAll();
        }
    }
}
