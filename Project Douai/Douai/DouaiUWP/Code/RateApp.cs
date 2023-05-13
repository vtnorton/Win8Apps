using DouaiCore.Code;
using UniversalRateReminder;

namespace DouaiUWP.Code
{
    public class RateApp
    {
        public static void RateThisApp()
        {
            RatePopup.LaunchLimit = RatePopupSettings.LaunchLimit;
            RatePopup.ResetCountOnNewVersion = RatePopupSettings.ResetCountOnNewVersion;
            RatePopup.RateButtonText = "Dê 5 estrelas!";
            RatePopup.CancelButtonText = "Não, obrigado";
            RatePopup.Title = "Classificar este aplicativo";
            RatePopup.Content = "Seus comentários me ajudam a melhorar este app. Se você gostar, por favor, classifique com 5 estrelas para que, dessa forma, eu continuo a criar atualizações e novas funções.";
            RatePopup.ResetLaunchCount();
            RatePopup.CheckRateReminderAsync();
        }
    }
}
