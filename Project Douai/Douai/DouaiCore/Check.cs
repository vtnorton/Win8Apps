using DouaiCore.Classes;
using Windows.Networking.Connectivity;

namespace DouaiCore
{
    public class Check
    {
        public static bool EhVerbo(string Verbo)
        {
            if (Verbo.EndsWith("ar") || Verbo.EndsWith("er") || Verbo.EndsWith("ir") || Verbo.EndsWith("or"))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Checar se o verbo é regular
        /// </summary>
        /// <param name="verbo">Verbo para ser checado, vale verificar se ele é um verbo</param>
        /// <returns></returns>
        public static bool EhVerboIrregular(string verbo)
        {
            foreach (var item in Irregulares.listaVerbosIrregulares())
            {
                if (item.Nome == verbo)
                    return true;
            }
            return false;
        }
        public static bool HasInternet()
        {
            ConnectionProfile connections = NetworkInformation.GetInternetConnectionProfile();
            return connections != null && connections.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
        }
    }
}
