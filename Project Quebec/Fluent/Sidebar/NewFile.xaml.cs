using ProjectQuebec.Code.FileHandle;
using ProjectQuebec.Code.LanguageSupport;
using ProjectQuebec.Code.Util;
using ProjectQuebec.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace ProjectQuebec.Fluent.Sidebar
{
    public sealed partial class NewFile : Page
    {
        IList<Sample> _SampleItens;

        #region APP
        public NewFile()
        {
            this.InitializeComponent();

            xCategory.ItemsSource = LanguageCategoryDataSource.GetAllLanguageCategory();
            btnBack.Visibility = Visibility.Collapsed;

            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.XamlCompositionBrushBase"))
            {
                try
                {
                    AcrylicBrush acrylicColor = new AcrylicBrush()
                    {
                        BackgroundSource = AcrylicBackgroundSource.HostBackdrop,
                        TintColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        FallbackColor = (Application.Current.Resources["rsColorMainBG"] as SolidColorBrush).Color,
                        TintOpacity = 0.9
                    };
                    xSample.Background = acrylicColor;
                    xLanguage.Background = acrylicColor;
                    xCategory.Background = acrylicColor;
                }
                catch (Exception)
                {
                    SolidColorBrush color = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                    xSample.Background = color;
                    xLanguage.Background = color;
                    xCategory.Background = color;
                }
            }
            else
            {
                SolidColorBrush color = Application.Current.Resources["rsColorMainBG"] as SolidColorBrush;
                xSample.Background = color;
                xLanguage.Background = color;
                xCategory.Background = color;
            }
        }
        #endregion

        #region EVENTS
        private void xCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (xLanguage.ItemsSource == null)
            {
                xSample.ItemsSource = null;

                switch (xCategory.SelectedIndex)
                {
                    case 0:
                        xLanguage.ItemsSource = LanguageDataSource.GetAllLanguage();
                        break;
                    default:
                        xLanguage.ItemsSource = LanguageDataSource.GetAllLanguageById(LanguageCategoryDataSource.GetLanguageCategoryById(xCategory.SelectedIndex).Languages);
                        break;
                }
            }

            Step1.Visibility = Visibility.Collapsed;
            Step2.Visibility = Visibility.Visible;
            btnBack.Visibility = Visibility.Visible;
        }
        private void xLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Language _language = (sender as ListView).SelectedItem as Language;

            xSample.ItemsSource = null;
            xSample.Items.Clear();

            if (_SampleItens != null)
                _SampleItens.Clear();

            SampleDataSouce samples = new SampleDataSouce();

            if (xLanguage.SelectedIndex != -1)
                _SampleItens = samples.GetAllSampleByLanguageId(_language);

            xSample.ItemsSource = _SampleItens;

            Step2.Visibility = Visibility.Collapsed;
            Step3.Visibility = Visibility.Visible;
            btnNext.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region METHODS
        private async void AddFile()
        {
            if (xSample.SelectedItem == null)
            {
                MessageDialog xMenssageDialog = new MessageDialog("Please select one file to be added", "Select one file to be added");
                await xMenssageDialog.ShowAsync();
            }
            else
            {
                if (!string.IsNullOrEmpty(txtFileName.Text))
                {
                    FileObject xFileToAdd = new FileObject()
                    {
                        File = null,
                        FileLanguage = _SampleItens[xSample.SelectedIndex].SampleLanguage,
                        FileName = txtFileName.Text,
                        FileType = _SampleItens[xSample.SelectedIndex].SampleExtention
                    };
                    xFileToAdd.DisplayName = xFileToAdd.FileName + xFileToAdd.FileType;

                    ///TODO: Transformar isso em um método só em uma classe separada (token)
                    string tosend = "";
                    StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Samples/" + _SampleItens[xSample.SelectedIndex].SampleURI));
                    var randomAcessStream = await file.OpenReadAsync();

                    Stream stream = randomAcessStream.AsStreamForRead();
                    using (StreamReader inputStream = new StreamReader(stream))
                    {
                        while (inputStream.Peek() >= 0)
                        {
                            tosend += inputStream.ReadLine() + Environment.NewLine;
                        }
                    }

                    if (tosend.Contains("<#NAME>"))
                        tosend = tosend.Replace("<#NAME>", txtFileName.Text);

                    xFileToAdd.ContentWithoutSaving = tosend;

                    new FileInteraction().CreateFile(xFileToAdd);

                    if (((Frame)Window.Current.Content).ActualWidth < 700 || DeviceTypeHelper.GetDeviceFormFactorType() == DeviceFormFactorType.Phone)
                        Frame.Navigate(typeof(Editor), xFileToAdd);
                }
                else
                {
                    MessageDialog xMenssageDialog = new MessageDialog("Plese, is it too much to ask you to input the name of the file? I appreciate that! ", "Put a name on it!");
                    await xMenssageDialog.ShowAsync();
                }
            }

            Step1.Visibility = Visibility.Visible;
            Step2.Visibility = Visibility.Collapsed;
            Step3.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Collapsed;
            btnNext.Visibility = Visibility.Visible;
        }
        #endregion

        #region INTERACTION
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddFile();
        }
        private async void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            if ((((Frame)Window.Current.Content).ActualWidth < 700) || DeviceTypeHelper.GetDeviceFormFactorType() == DeviceFormFactorType.Phone)
                Frame.Navigate(typeof(Editor), FileOpend.AllFilesList[await new FileInteraction().OpenFile()]);
            else
                await new FileInteraction().OpenFile();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (Step2.Visibility == Visibility.Visible)
            {
                Step1.Visibility = Visibility.Visible;
                Step2.Visibility = Visibility.Collapsed;
                btnBack.Visibility = Visibility.Collapsed;
            }
            else if (Step3.Visibility == Visibility.Visible)
            {
                btnNext.Visibility = Visibility.Visible;
                Step2.Visibility = Visibility.Visible;
                Step3.Visibility = Visibility.Collapsed;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (Step1.Visibility == Visibility.Visible)
            {
                btnBack.Visibility = Visibility.Visible;
                Step2.Visibility = Visibility.Visible;
                Step1.Visibility = Visibility.Collapsed;
            }
            else if (Step2.Visibility == Visibility.Visible)
            {
                Step3.Visibility = Visibility.Visible;
                Step2.Visibility = Visibility.Collapsed;
                btnNext.Visibility = Visibility.Collapsed;
            }
        }
        private void txtFileName_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                if (FocusManager.GetFocusedElement() == txtFileName)
                {
                    FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
                    FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
                }
                else
                {
                    FocusManager.TryMoveFocus(FocusNavigationDirection.Next);
                }
                AddFile();
                e.Handled = true;
            }
        }
        #endregion
    }
}
