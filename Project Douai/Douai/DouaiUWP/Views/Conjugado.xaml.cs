using DouaiCore;
using DouaiCore.Classes;
using DouaiUWP.Code;
using System;
using Windows.ApplicationModel.Store;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace DouaiUWP.Views
{
    public sealed partial class Conjugado : Page
    {
        
        private static string verboRecebido;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            verboRecebido = (string)e.Parameter;
            ConjulgarVerbo(verboRecebido.ToLower().Trim());
        }

        public Conjugado()
        {
            this.InitializeComponent();
            if (GerenciadorDePacotes.HasPackForAds())
            {
                Ad.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConjulgarVerbo(txtVerbo.Text.ToLower().Trim());
        }

        private async void ConjulgarVerbo(string xverbo)
        {
            if (Check.EhVerbo(xverbo))
            {
                if (Check.EhVerboIrregular(xverbo))
                {
                    if (!GerenciadorDePacotes.HasPackForIrregular())
                    {
                        PurchaseResults result = await CurrentApp.RequestProductPurchaseAsync(InApp.TokenIrregularesEAnuncios);
                        //PurchaseResults result = await CurrentAppSimulator.RequestProductPurchaseAsync(InApp.TokenIrregularesEAnuncios);

                        switch (result.Status)
                        {
                            case ProductPurchaseStatus.AlreadyPurchased:
                                ConjugarIrregularComprado(xverbo);
                                await new MessageDialog("Você já comprou esse produto e não deveria ver essa mensagem", "Houve um erro :(").ShowAsync();
                                break;
                            case ProductPurchaseStatus.Succeeded:
                                ConjugarIrregularComprado(xverbo);
                                await new MessageDialog("Compra realizada com sucesso", "Sucesso").ShowAsync();
                                break;
                            case ProductPurchaseStatus.NotPurchased:
                                await new MessageDialog("Houve um erro, tente novamente mais tarde", "Houve um erro :(").ShowAsync();
                                break;
                        }
                    }
                    else
                    {
                        ConjugarIrregularComprado(xverbo);
                    }
                }
                else
                {
                    Verbo verboConjugado = Conjugar.ConjugadorRegular(xverbo);
                    lblPresente.Text = verboConjugado.Presente;
                    lblFuturoDoPresente.Text = verboConjugado.FuturoDoPresente;
                    lblFuturoDoPreterito.Text = verboConjugado.FuturoDoPreterito;
                    lblFuturoDoSubjuntivo.Text = verboConjugado.FuturoDoSubjuntivo;
                    lblImperativo.Text = verboConjugado.ImperativoAfirmativo;
                    lblImperativoNegativo.Text = verboConjugado.ImperativoNegativo;
                    lblPresenteDoSubjuntivo.Text = verboConjugado.PresenteDoSubjuntivo;
                    lblPreteritoImperfeito.Text = verboConjugado.PreteritoImperfeito;
                    lblPreteritoImperfeitoDoSubjuntivo.Text = verboConjugado.PreteritoImperfeitoDoSubjuntivo;
                    lblPreteritoMaisQuePerfeito.Text = verboConjugado.PreteritoMaisQuePerfeito;
                    lblPreteritoPerfeito.Text = verboConjugado.PreteritoPerfeito;
                    lblPrincipal.Text = verboConjugado.Principal;
                    lblInfinitivo.Text = verboConjugado.InfinitivoPessoal;
                }
            }
            else
            {
                await new MessageDialog("O que você está tentando conjugar não é um verbo ou não está na forma infinitiva, tente novamente!", "Não é um verbo").ShowAsync();
            }
        }
        private void ConjugarIrregularComprado(string xverbo)
        {
            Verbo verboConjugado = Conjugar.ConjugadorIrregular(xverbo);
            lblPresente.Text = verboConjugado.Presente;
            lblFuturoDoPresente.Text = verboConjugado.FuturoDoPresente;
            lblFuturoDoPreterito.Text = verboConjugado.FuturoDoPreterito;
            lblFuturoDoSubjuntivo.Text = verboConjugado.FuturoDoSubjuntivo;
            lblImperativo.Text = verboConjugado.ImperativoAfirmativo;
            lblImperativoNegativo.Text = verboConjugado.ImperativoNegativo;
            lblPresenteDoSubjuntivo.Text = verboConjugado.PresenteDoSubjuntivo;
            lblPreteritoImperfeito.Text = verboConjugado.PreteritoImperfeito;
            lblPreteritoImperfeitoDoSubjuntivo.Text = verboConjugado.PreteritoImperfeitoDoSubjuntivo;
            lblPreteritoMaisQuePerfeito.Text = verboConjugado.PreteritoMaisQuePerfeito;
            lblPreteritoPerfeito.Text = verboConjugado.PreteritoPerfeito;
            lblPrincipal.Text = verboConjugado.Principal;
            lblInfinitivo.Text = verboConjugado.InfinitivoPessoal;
        }
    }
}
