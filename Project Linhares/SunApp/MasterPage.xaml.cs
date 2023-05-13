using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SunApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MasterPage : Page
    {
        /// <summary>
        /// 1: Home
        /// 2: Plantation
        /// 3: Financial
        /// 4: Humans
        /// 5: Settings
        /// 6: Help
        /// 7: About
        /// </summary>
        private int Selected;
        private SolidColorBrush fillGreen = new SolidColorBrush(ColorHelper.FromArgb(255, 21, 153, 42));
        private SolidColorBrush fillWhite = new SolidColorBrush(Colors.White);
        private SolidColorBrush fillTransparent = new SolidColorBrush(Colors.Transparent);
        private SolidColorBrush fillGray = new SolidColorBrush(ColorHelper.FromArgb(255,46,46,46));

        public MasterPage()
        {
            this.InitializeComponent();
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.BackgroundColor = ColorHelper.FromArgb(255, 21, 153, 42);
            titleBar.InactiveBackgroundColor = Colors.Green;
            titleBar.InactiveForegroundColor = Colors.White;
            titleBar.ButtonInactiveForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = ColorHelper.FromArgb(255, 21, 153, 42);
            titleBar.ButtonInactiveBackgroundColor = Colors.Green;
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
            FillGreenHome();
            Selected = 1;
        }

        private void btnPlantation_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Agronomy.MainAgronomy));
            ResetAll();
            FillGreenPlantation();
            Selected = 2;
        }

        private void btnFinancial_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Financial.MainFinancial));
            ResetAll();
            FillGreenFinancial();
            Selected = 3;
        }

        private void btnHumans_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Humans.MainHumans));
            ResetAll();
            FillGreenHumans();
            Selected = 4;
        }

        private void btnSettings_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Settings));
            ResetAll();
            FillGreenSettings();
            Selected = 5;
        }

        private void btnHelp_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Help));
            ResetAll();
            FillGreenHelp();
            Selected = 6;
        }

        private void btnAbout_Click(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.About));
            ResetAll();
            FillGreenAbout();
            Selected = 7;
        }

        private void ResetAll()
        {
            txtAbout.Foreground = fillWhite;
            txtFinancial.Foreground = fillWhite;
            txtHelp.Foreground = fillWhite;
            txtHome.Foreground = fillWhite;
            txtHumans.Foreground = fillWhite;
            txtPlantation.Foreground = fillWhite;
            txtSettings.Foreground = fillWhite;
            btnHome.Foreground = fillWhite;
            btnAbout.Foreground = fillWhite;
            btnFinancial.Foreground = fillWhite;
            btnHelp.Foreground = fillWhite;
            btnHumans.Foreground = fillWhite;
            btnMenu.Foreground = fillWhite;
            btnPlantation.Foreground = fillWhite;
            btnSettings.Foreground = fillWhite;
            gridAbout.Background = fillTransparent;
            gridFinancial.Background = fillTransparent;
            gridHelp.Background = fillTransparent;
            gridHome.Background = fillTransparent;
            gridHumans.Background = fillTransparent;
            gridPlantation.Background = fillTransparent;
            gridSettings.Background = fillTransparent;
        }

        private void stpHome_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHome.Background = fillGray;
            gridHome.Background = fillGreen;
            btnHome.Foreground = fillWhite;
        }

        private void stpHome_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 1)
            {
                FillGreenHome();
            }
            else
            {
                stpHome.Background = fillTransparent;
                gridHome.Background = fillTransparent;
            }
        }

        private void stpPlantation_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpPlantation.Background = fillGray;
            gridPlantation.Background = fillGreen;
            btnPlantation.Foreground = fillWhite;
        }

        private void stpPlantation_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 2)
            {
                FillGreenPlantation();
            }
            else
            {
                stpPlantation.Background = fillTransparent;
                gridPlantation.Background = fillTransparent;
            }
        }

        private void stpFinancial_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpFinancial.Background = fillGray;
            gridFinancial.Background = fillGreen;
            btnFinancial.Foreground = fillWhite;
        }

        private void stpFinancial_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 3)
            {
                FillGreenFinancial();
            }
            else
            {
                stpFinancial.Background = fillTransparent;
                gridFinancial.Background = fillTransparent;
            }
        }

        private void stpHumans_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHumans.Background = fillGray;
            gridHumans.Background = fillGreen;
            btnHumans.Foreground = fillWhite;
        }

        private void stpHumans_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 4)
            {
                FillGreenHumans();
            }
            else
            {
                stpHumans.Background = fillTransparent;
                gridHumans.Background = fillTransparent;
            }
        }

        private void stpSetting_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpSetting.Background = fillGray;
            gridSettings.Background = fillGreen;
            btnSettings.Foreground = fillWhite;
        }
        private void stpSetting_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 5)
            {
                FillGreenSettings();
            }
            else
            {
                stpSetting.Background = fillTransparent;
                gridSettings.Background = fillTransparent;
            }
        }

        private void stpHelp_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpHelp.Background = fillGray;
            gridHelp.Background = fillGreen;
            btnHelp.Foreground = fillWhite;
        }

        private void stpHelp_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 6)
            {
                FillGreenHelp();
            }
            else
            {
                stpHelp.Background = fillTransparent;
                gridHelp.Background = fillTransparent;
            }
        }

        private void stpAbout_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            stpAbout.Background = fillGray;
            gridAbout.Background = fillGreen;
            btnAbout.Foreground = fillWhite;
        }

        private void stpAbout_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if(Selected == 7)
            {
                FillGreenAbout();
            }
            else
            {
                stpAbout.Background = fillTransparent;
                gridAbout.Background = fillTransparent;
            }
        }

        private void FillGreenHome()
        {
            gridHome.Background = fillGreen;
            txtHome.Foreground = fillGreen;
            btnHome.Foreground = fillGreen;
            btnHome.Background = fillTransparent;
            stpHome.Background = fillTransparent;
        }
        private void FillGreenPlantation()
        {
            gridPlantation.Background = fillGreen;
            txtPlantation.Foreground = fillGreen;
            btnPlantation.Foreground = fillGreen;
            btnPlantation.Background = fillTransparent;
            stpPlantation.Background = fillTransparent;
        }
        private void FillGreenFinancial()
        {
            gridFinancial.Background = fillGreen;
            txtFinancial.Foreground = fillGreen;
            btnFinancial.Foreground = fillGreen;
            btnFinancial.Background = fillTransparent;
            stpFinancial.Background = fillTransparent;
        }
        private void FillGreenHumans()
        {
            gridHumans.Background = fillGreen;
            txtHumans.Foreground = fillGreen;
            btnHumans.Foreground = fillGreen;
            btnHumans.Background = fillTransparent;
            stpHumans.Background = fillTransparent;
        }
        private void FillGreenSettings()
        {
            gridSettings.Background = fillGreen;
            txtSettings.Foreground = fillGreen;
            btnSettings.Foreground = fillGreen;
            btnSettings.Background = fillTransparent;
            stpSetting.Background = fillTransparent;
        }
        private void FillGreenHelp()
        {
            gridHelp.Background = fillGreen;
            txtHelp.Foreground = fillGreen;
            btnHelp.Foreground = fillGreen;
            btnHelp.Background = fillTransparent;
            stpHelp.Background = fillTransparent;
        }
        private void FillGreenAbout()
        {
            gridAbout.Background = fillGreen;
            txtAbout.Foreground = fillGreen;
            btnAbout.Foreground = fillGreen;
            btnAbout.Background = fillTransparent;
            stpAbout.Background = fillTransparent;
        }
    }
}
