using ProjectRedmonde.Code;
using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace ProjectRedmonde.Views
{
    public sealed partial class Spotlight : Page
    {
        public Spotlight()
        {
            this.InitializeComponent();
        }

        private int GetWidth(string url)
        {
            return new BitmapImage(new Uri(url, UriKind.Relative)).PixelWidth;
        }

        private int GetHeight(string url)
        {
            return new BitmapImage(new Uri(url, UriKind.Relative)).PixelHeight;
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            int Results = 1;

            MyAdaptiveGridViewControl.ItemsSource = PhotosDataSource.SearchPhotos();

            if (Results > 0)
            {
                gridGallery.Visibility = Visibility.Visible;
                gridNoContent.Visibility = Visibility.Collapsed;
                gridOptions.Visibility = Visibility.Collapsed;
            }
            else
            {
                gridGallery.Visibility = Visibility.Collapsed;
                gridNoContent.Visibility = Visibility.Visible;
                gridOptions.Visibility = Visibility.Visible;
            }
        }

        #region ButtonsClick
        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            btnShowAll.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            btnShowMobile.Foreground = new SolidColorBrush(Colors.Black);
            btnShowDesktop.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void btnShowMobile_Click(object sender, RoutedEventArgs e)
        {
            btnShowAll.Foreground = new SolidColorBrush(Colors.Black);
            btnShowMobile.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            btnShowDesktop.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void btnShowDesktop_Click(object sender, RoutedEventArgs e)
        {
            btnShowDesktop.Foreground = new SolidColorBrush(Colors.DodgerBlue);
            btnShowMobile.Foreground = new SolidColorBrush(Colors.Black);
            btnShowAll.Foreground = new SolidColorBrush(Colors.Black);
        }
        #endregion
    }
}
