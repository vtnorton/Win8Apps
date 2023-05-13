using DouaiUWP.Code;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Store;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

namespace DouaiUWP
{
    sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeLicense();
            Suspending += OnSuspending;
        }
        private void InitializeLicense()
        {
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            // Remove these lines of code before publishing! 
            // The actual CurrentApp will create a WindowsStroeProxy.xml
            // in the package's \LocalState\Microsoft\Windows Store\ApiData 
            // folder where it stroes the actual purchases.
            // Here we're just giving it a fake version of that file for testing.
            //StorageFile proxyFile = await Package.Current.InstalledLocation.GetFileAsync("Code\\InApp.xml");
            //await CurrentAppSimulator.ReloadSimulatorAsync(proxyFile);
            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            LicenseManager.AppLicenseInformation = CurrentApp.LicenseInformation;
        }
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Views.MasterPage;

            if (rootFrame == null)
            {
                rootFrame = new Views.MasterPage();
                rootFrame.ContentFrame.NavigationFailed += OnNavigationFailed;
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.ContentFrame.Content == null)
            {
                if (!rootFrame.ContentFrame.Navigate(typeof(Views.MainPage)))
                    throw new Exception("Failed to create initial page");
            }

            Window.Current.Activate();
            MobileCenter.Start("a40bf391-d9d8-48f7-ac3d-0089f2097d25", typeof(Analytics));
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
