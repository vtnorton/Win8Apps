using DouaiCore;
using DouaiUWP.Code;
using System;
using Windows.ApplicationModel.Store;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiUWP.Views
{
    public sealed partial class AddIn : Page
    {
        ListingInformation listing;
        public AddIn()
        {
            this.InitializeComponent();
        }
        private async void LoadLicenseInfo()
        {
            listing = await CurrentApp.LoadListingInformationAsync();
            
        }
        private async void ErroAoAtualizarPrecos()
        {
            await new MessageDialog("Tentamos atualizar o preço dos produtos, mas houve um erro.", "Houve um erro :(").ShowAsync();
        }
        private async void ErroSemInternet()
        {
            await new MessageDialog("O aplicativo não possui conexão com internet no momento, por favor, volte novamente mais tarde", "Houve um erro :(").ShowAsync();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (Check.HasInternet())
            {
                try
                {
                    LoadLicenseInfo();
                    btnDonation.Content = listing.ProductListings[InApp.TokenDonation].FormattedPrice;
                    btnDonation2.Content = listing.ProductListings[InApp.TokenDonation2].FormattedPrice;
                    btnIrregularesEAnuncios.Content = listing.ProductListings[InApp.TokenDonation2].FormattedPrice;
                    btnRemoverAnuncios.Content = listing.ProductListings[InApp.TokenRemoverAnuncios].FormattedPrice;
                    btnAdicionarVerbos.Content = listing.ProductListings[InApp.TokenAdicionarVerbos].FormattedPrice;
                }
                catch (Exception)
                {
                    ErroAoAtualizarPrecos();
                }
            }
            else
                ErroSemInternet();
            

            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation2].IsActive)
            {
                HideIrregularesEAnuncios();
                HideRemoverAnuncios();
                HideAdicionarVerbos();
                HideDonation();
                HideDonation2();
            }
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation].IsActive)
            {
                HideIrregularesEAnuncios();
                HideRemoverAnuncios();
                HideAdicionarVerbos();
                HideDonation();
            }
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenIrregularesEAnuncios].IsActive)
            {
                HideIrregularesEAnuncios();
                HideRemoverAnuncios();
                HideAdicionarVerbos();
            }
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenRemoverAnuncios].IsActive)
            {
                HideRemoverAnuncios();
                HideIrregularesEAnuncios();
            }
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenAdicionarVerbos].IsActive)
                HideAdicionarVerbos();
        }

        private async void btnDonation2_Click(object sender, RoutedEventArgs e)
        {
            if (!LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation2].IsActive)
            {
                try
                {
                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenDonation2);
                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        HideAdicionarVerbos();
                        HideDonation();
                        HideDonation2();
                        HideIrregularesEAnuncios();
                        HideRemoverAnuncios();

                        await new MessageDialog("Obrigado pela doação, sua compra foi realizada com sucesso! ;)", "Compra realizada com sucesso!").ShowAsync();
                    }
                }
                catch (Exception)
                {
                    await new MessageDialog("Ocorreu um erro na compra do pacote. Veja se não é a sua internet ou se os serviços da Windows Store estão ativos.", "Houve um erro :(").ShowAsync();
                }
            }
            else
            {
                await new MessageDialog("Você já comprou esse pacote! Obrigado ;)", "Você já tem esse pacote").ShowAsync();
            }
        }

        private async void btnDonation_Click(object sender, RoutedEventArgs e)
        {
            if (!LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation].IsActive)
            {
                try
                {
                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenDonation);
                    //PurchaseResults results = await CurrentAppSimulator.RequestProductPurchaseAsync(InApp.TokenDonation);
                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        HideAdicionarVerbos();
                        HideDonation();
                        HideIrregularesEAnuncios();
                        HideRemoverAnuncios();
                        await new MessageDialog("Obrigado pela doação, sua compra foi realizada com sucesso! ;)", "Compra realizada com sucesso!").ShowAsync();
                    }
                }
                catch (Exception)
                {
                    await new MessageDialog("Ocorreu um erro na compra do pacote. Veja se não é a sua internet ou se os serviços da Windows Store estão ativos.", "Houve um erro :(").ShowAsync();
                }
            }
            else
            {
                await new MessageDialog("Você já comprou esse pacote! Obrigado ;)", "Você já tem esse pacote").ShowAsync();
            }
        }

        private async void btnIrregularesEAnuncios_Click(object sender, RoutedEventArgs e)
        {
            if (!LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenIrregularesEAnuncios].IsActive)
            {
                try
                {
                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenIrregularesEAnuncios);
                    //PurchaseResults results = await CurrentAppSimulator.RequestProductPurchaseAsync(InApp.TokenIrregularesEAnuncios);
                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        HideAdicionarVerbos();
                        HideIrregularesEAnuncios();
                        HideRemoverAnuncios();
                        await new MessageDialog("Obrigado, sua compra foi realizada com sucesso! ;)", "Compra realizada com sucesso!").ShowAsync();
                    }
                }
                catch (Exception)
                {
                    await new MessageDialog("Ocorreu um erro na compra do pacote. Veja se não é a sua internet ou se os serviços da Windows Store estão ativos.", "Houve um erro :(").ShowAsync();
                }
            }
            else
            {
                await new MessageDialog("Você já comprou esse pacote! Obrigado ;)", "Você já tem esse pacote").ShowAsync();
            }
        }

        private async void btnRemoverAnuncios_Click(object sender, RoutedEventArgs e)
        {
            if (!LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenRemoverAnuncios].IsActive)
            {
                try
                {
                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenRemoverAnuncios);
                    //PurchaseResults results = await CurrentAppSimulator.RequestProductPurchaseAsync(InApp.TokenRemoverAnuncios);
                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        HideIrregularesEAnuncios();
                        HideRemoverAnuncios();
                        await new MessageDialog("Obrigado, sua compra foi realizada com sucesso! ;)", "Compra realizada com sucesso!").ShowAsync();
                    }
                }
                catch (Exception)
                {
                    await new MessageDialog("Ocorreu um erro na compra do pacote. Veja se não é a sua internet ou se os serviços da Windows Store estão ativos.", "Houve um erro :(").ShowAsync();
                }
            }
            else
            {
                await new MessageDialog("Você já comprou esse pacote! Obrigado ;)", "Você já tem esse pacote").ShowAsync();
            }
        }

        private async void btnAdicionarVerbos_Click(object sender, RoutedEventArgs e)
        {
            if (!LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenAdicionarVerbos].IsActive)
            {
                try
                {
                    PurchaseResults results = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenAdicionarVerbos);
                    //PurchaseResults results = await CurrentAppSimulator.RequestProductPurchaseAsync(InApp.TokenAdicionarVerbos);
                    if (results.Status == ProductPurchaseStatus.Succeeded)
                    {
                        HideAdicionarVerbos();
                        await new MessageDialog("Obrigado, sua compra foi realizada com sucesso! ;)", "Compra realizada com sucesso!").ShowAsync();
                    }
                }
                catch (Exception)
                {
                    await new MessageDialog("Ocorreu um erro na compra do pacote. Veja se não é a sua internet ou se os serviços da Windows Store estão ativos.", "Houve um erro :(").ShowAsync();
                }
            }
            else
            {
                await new MessageDialog("Você já comprou esse pacote! Obrigado ;)", "Você já tem esse pacote").ShowAsync();
            }
        }


        private void HideDonation2()
        {
            btnDonation2.Visibility = Visibility.Collapsed;
            btnCompradoDonation2.Visibility = Visibility.Visible;
        }
        private void HideDonation()
        {
            btnDonation.Visibility = Visibility.Collapsed;
            btnCompradoDonation.Visibility = Visibility.Visible;
        }
        private void HideAdicionarVerbos()
        {
            btnAdicionarVerbos.Visibility = Visibility.Collapsed;
            btnCompradoAdicionarVerbos.Visibility = Visibility.Visible;
        }
        private void HideRemoverAnuncios()
        {
            btnRemoverAnuncios.Visibility = Visibility.Collapsed;
            btnCompradoRemoverAnuncios.Visibility = Visibility.Visible;
        }
        private void HideIrregularesEAnuncios()
        {
            btnIrregularesEAnuncios.Visibility = Visibility.Collapsed;
            btnCompradoIrregularesEAnuncios.Visibility = Visibility.Visible;
        }
    }
}
