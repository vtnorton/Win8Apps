using DouaiUWP.Code;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Store;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace DouaiUWP.Views
{
    public sealed partial class MasterPage : Page
    {
        private int Selected;
        private SolidColorBrush fillColor = new SolidColorBrush(Colors.Green);
        private SolidColorBrush fillWhite = new SolidColorBrush(Colors.White);
        private SolidColorBrush fillTransparent = new SolidColorBrush(Colors.Transparent);
        private SolidColorBrush fillGray = new SolidColorBrush(ColorHelper.FromArgb(255, 46, 46, 46));
        public MasterPage()
        {
            this.InitializeComponent();
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = Colors.Green;
            titleBar.InactiveBackgroundColor = Colors.Green;
            titleBar.InactiveForegroundColor = Colors.White;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Colors.Green;
            titleBar.ButtonInactiveBackgroundColor = Colors.Green;
            FillColorHome();

            this.SizeChanged += (s, e) =>
            {
                var state = "VisualState000min";
                if (e.NewSize.Width > 641)
                    state = "VisualState641min";
                else if (e.NewSize.Width > 941)
                    state = "VisualState941min";
                VisualStateManager.GoToState(this, state, true);
            };
        }

        public Frame ContentFrame
        {
            get { return this.frameBody; }
        }
        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            MySliptView.IsPaneOpen = !MySliptView.IsPaneOpen;
        }
        private void xtnHome_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(MainPage));
            ResetAll();
            FillColorHome();
            Selected = 1;
        }
        private void btnHelp_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Help));
            ResetAll();
            FillColorHelp();
            Selected = 6;
        }

        private void btnAbout_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(About));
            ResetAll();
            FillColorAbout();
            Selected = 7;
        }

        private void ResetAll()
        {
            txtAbout.Foreground = fillWhite;
            txtHelp.Foreground = fillWhite;
            txtHome.Foreground = fillWhite;
            txtAddIn.Foreground = fillWhite;
            txtChangelog.Foreground = fillWhite;
            txtFeedback.Foreground = fillWhite;
            btnHome.Foreground = fillWhite;
            btnAbout.Foreground = fillWhite;
            btnHelp.Foreground = fillWhite;
            btnMenu.Foreground = fillWhite;
            btnAddIn.Foreground = fillWhite;
            btnChangelog.Foreground = fillWhite;
            btnFeedback.Foreground = fillWhite;
            gridAbout.Background = fillTransparent;
            gridHelp.Background = fillTransparent;
            gridHome.Background = fillTransparent;
            gridAddIn.Background = fillTransparent;
            gridChangelog.Background = fillTransparent;
            gridFeedcak.Background = fillTransparent;
        }
        private void stpHome_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHome.Background = fillGray;
            gridHome.Background = fillColor;
            btnHome.Foreground = fillWhite;
        }

        private void stpHome_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 1)
                FillColorHome();
            else
            {
                stpHome.Background = fillTransparent;
                gridHome.Background = fillTransparent;
            }
        }

        private void stpHelp_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHelp.Background = fillGray;
            gridHelp.Background = fillColor;
            btnHelp.Foreground = fillWhite;
        }

        private void stpHelp_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 6)
                FillColorHelp();
            else
            {
                stpHelp.Background = fillTransparent;
                gridHelp.Background = fillTransparent;
            }
        }

        private void stpAbout_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpAbout.Background = fillGray;
            gridAbout.Background = fillColor;
            btnAbout.Foreground = fillWhite;
        }

        private void stpAbout_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 7)
                FillColorAbout();
            else
            {
                stpAbout.Background = fillTransparent;
                gridAbout.Background = fillTransparent;
            }
        }

        private void FillColorHome()
        {
            gridHome.Background = fillColor;
            txtHome.Foreground = fillColor;
            btnHome.Foreground = fillColor;
            btnHome.Background = fillTransparent;
            stpHome.Background = fillTransparent;
        }
        private void FillColorHelp()
        {
            gridHelp.Background = fillColor;
            txtHelp.Foreground = fillColor;
            btnHelp.Foreground = fillColor;
            btnHelp.Background = fillTransparent;
            stpHelp.Background = fillTransparent;
        }
        private void FillColorAbout()
        {
            gridAbout.Background = fillColor;
            txtAbout.Foreground = fillColor;
            btnAbout.Foreground = fillColor;
            btnAbout.Background = fillTransparent;
            stpAbout.Background = fillTransparent;
        }

        private void FillColorFeedback()
        {
            gridFeedcak.Background = fillColor;
            txtFeedback.Foreground = fillColor;
            btnFeedback.Foreground = fillColor;
            btnFeedback.Background = fillTransparent;
            stpFeedback.Background = fillTransparent;
        }

        private void FillColorChangelog()
        {
            gridChangelog.Background = fillColor;
            txtChangelog.Foreground = fillColor;
            btnChangelog.Foreground = fillColor;
            btnChangelog.Background = fillTransparent;
            stpChangelog.Background = fillTransparent;
        }

        private void FillColorAddIn()
        {
            gridAddIn.Background = fillColor;
            txtAddIn.Foreground = fillColor;
            btnAddIn.Foreground = fillColor;
            btnAddIn.Background = fillTransparent;
            stpAddIn.Background = fillTransparent;
        }

        private void stpChangelog_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Changelog));
            ResetAll();
            FillColorChangelog();
            Selected = 2;
        }

        private void stpChangelog_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpChangelog.Background = fillGray;
            gridChangelog.Background = fillColor;
            btnChangelog.Foreground = fillWhite;
        }

        private void stpChangelog_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 2)
                FillColorChangelog();
            else
            {
                stpChangelog.Background = fillTransparent;
                gridChangelog.Background = fillTransparent;
            }
        }

        private void stpFeedback_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(SendFeedback));
            ResetAll();
            FillColorFeedback();
            Selected = 3;
        }

        private void stpFeedback_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpFeedback.Background = fillGray;
            gridFeedcak.Background = fillColor;
            btnFeedback.Foreground = fillWhite;
        }

        private void stpFeedback_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 3)
                FillColorFeedback();
            else
            {
                stpFeedback.Background = fillTransparent;
                gridFeedcak.Background = fillTransparent;
            }
        }

        private void stpAddIn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(AddIn));
            ResetAll();
            FillColorAddIn();
            Selected = 4;
        }

        private void stpAddIn_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpAddIn.Background = fillGray;
            gridAddIn.Background = fillColor;
            btnAddIn.Foreground = fillWhite;
        }

        private void stpAddIn_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (Selected == 4)
                FillColorAddIn();
            else
            {
                stpAddIn.Background = fillTransparent;
                gridAddIn.Background = fillTransparent;
            }
        }
    }
}
