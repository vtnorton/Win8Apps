using ProjectNice.Code;
using System;
using UniversalRateReminder;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

namespace ProjectNice
{
    sealed partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }
        
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var rootFrame = Window.Current.Content as MasterPage;
            if (rootFrame == null)
            {
                rootFrame = new MasterPage();
                rootFrame.ContentFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.ContentFrame.Content == null)
            {
                if (!rootFrame.ContentFrame.Navigate(typeof(MainPage)))
                    throw new Exception("Failed to create initial page");
            }
            Window.Current.Activate();

            MobileCenter.Start("97533ac2-e20a-4ac8-a59e-744e939a5d64", typeof(Analytics));

            RatePopup.LaunchLimit = RatePopupSettings.LaunchLimit;
            RatePopup.ResetCountOnNewVersion = RatePopupSettings.ResetCountOnNewVersion;
            RatePopup.RateButtonText = LocalizedStrings.Get("RatePopupRateButton", "Shared");
            RatePopup.CancelButtonText = LocalizedStrings.Get("RatePopupCancelButton", "Shared");
            RatePopup.Title = LocalizedStrings.Get("RatePopupTitle", "Shared");
            RatePopup.Content = LocalizedStrings.Get("RatePupupContent", "Shared");
            RatePopup.CheckRateReminderAsync();
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
