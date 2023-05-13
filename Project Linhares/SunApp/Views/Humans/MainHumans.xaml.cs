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

namespace SunApp.Views.Humans
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainHumans : Page
    {
        public MainHumans()
        {
            this.InitializeComponent();
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ViewClients));
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ViewEmployee));
        }
    }
}
