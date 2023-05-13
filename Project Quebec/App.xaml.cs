using ProjectQuebec.Code.FileHandle;
using System;
using UniversalRateReminder;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
//using Microsoft.Azure.Mobile;
//using Microsoft.Azure.Mobile.Analytics;
using ProjectQuebec.Fluent.UICode;
using System.Collections.Generic;
using Windows.UI.Xaml.Media;
using ProjectQuebec.Code.Util;
using Windows.Globalization;
using ProjectQuebec.Code.Settings;

namespace ProjectQuebec
{
    public sealed partial class App : Application
    {
        internal IList<IPage> Views = new List<IPage>();
        ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
        public App()
        {
            if (localSettings.Values["theme"] != null)
            {
                if (localSettings.Values["theme"].ToString() == "light")
                    RequestedTheme = ApplicationTheme.Light;
                else
                    RequestedTheme = ApplicationTheme.Dark;
            }

            if (localSettings.Values["language"] != null)
                ApplicationLanguages.PrimaryLanguageOverride = SettingsUtil.AppLanguagesKey[int.Parse(localSettings.Values["language"].ToString())];

            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }
        protected override void OnActivated(IActivatedEventArgs args)
        {
            switch (args.Kind)
            {
                case ActivationKind.CommandLineLaunch:

                    CommandLineActivatedEventArgs cmdLineArgs = args as CommandLineActivatedEventArgs;
                    CommandLineActivationOperation operation = cmdLineArgs.Operation;
                    string cmdLineString = operation.Arguments;
                    string activationPath = operation.CurrentDirectoryPath;

                    Frame rootFrame = Window.Current.Content as Frame;
                    if (rootFrame == null)
                    {
                        rootFrame = new Frame();
                        Window.Current.Content = rootFrame;
                    }
                    rootFrame.Navigate(typeof(Fluent.MasterPage));
                    Window.Current.Activate();

                    break;
            }
        }
        protected override void OnFileActivated(FileActivatedEventArgs args)
        {
            base.OnFileActivated(args);
            var rootFrame = new Frame();
            var fileArgs = args as FileActivatedEventArgs;
            string strFilePath = fileArgs.Files[0].Path;
            StorageFile xStoragedFile = (StorageFile)fileArgs.Files[0];

            FileOpend.AllFilesList.Add(FileInteraction.StorageFileToFileObj(xStoragedFile));

            rootFrame.Navigate(typeof(Fluent.MasterPage), FileOpend.AllFilesList[0]);

            Window.Current.Content = rootFrame;
            Window.Current.Activate();
            Helpers._openFileEvent.Add(0);
        }
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
            {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += OnNavigationFailed;
                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                }
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(Fluent.MasterPage), e.Arguments);
                }

                Window.Current.Activate();

                if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
                {
                    var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                    if (titleBar != null)
                    {
                        titleBar.ButtonForegroundColor = (Current.Resources["rsColorMainText"] as SolidColorBrush).Color;
                        titleBar.ButtonBackgroundColor = Colors.Transparent;
                        titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
                        titleBar.BackgroundColor = Colors.Transparent;
                    }
                }

                if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
                {
                    var statusBar = StatusBar.GetForCurrentView();
                    statusBar.BackgroundColor = (Current.Resources["rsColorBackgroundColor"] as SolidColorBrush).Color;
                    statusBar.ForegroundColor = (Current.Resources["rsColorForegroundColor"] as SolidColorBrush).Color;
                    statusBar.BackgroundOpacity = 1;
                }

                RatePopup.LaunchLimit = 2;
                RatePopup.ResetCountOnNewVersion = true;
                RatePopup.RateButtonText = "Rate 5 stars";
                RatePopup.CancelButtonText = "No, thanks";
                RatePopup.Title = "Rate this app";
                RatePopup.Content = "Your feedback help me improve this app. If you like it, please, rate with 5 star so, that way, I continue to create new functions and updates.";
                RatePopup.CheckRateReminderAsync();
            }

            //MobileCenter.Start("f1c09abc-d8ff-4df8-8f4b-ea92816eff89", typeof(Analytics));
        }
        public void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
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
