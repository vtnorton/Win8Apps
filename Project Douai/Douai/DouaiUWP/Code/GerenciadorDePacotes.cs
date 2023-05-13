using DouaiCore;

namespace DouaiUWP.Code
{
    public static class GerenciadorDePacotes
    {
        public static bool HasPackForIrregular()
        {
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenAdicionarVerbos].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenIrregularesEAnuncios].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation2].IsActive)
                return true;
            else
                return false;
        }
        public static bool HasPackForAds()
        {
            if (LicenseManager.AppLicenseInformation.ProductLicenses[InApp.StoreIDRemoverAnuncios].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenIrregularesEAnuncios].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation].IsActive ||
                LicenseManager.AppLicenseInformation.ProductLicenses[InApp.TokenDonation2].IsActive)
                return true;
            else
                return false;
        }
    }
}
