using UniversalRateReminder;

namespace ProjectQuebec.Code.Util
{
    public class RateApp
    {
        public static void RateThisApp()
        {
            RatePopup.LaunchLimit = 9;
            RatePopup.ResetCountOnNewVersion = false;
            RatePopup.RateButtonText = "Rate 5 stars";
            RatePopup.CancelButtonText = "No, thanks";
            RatePopup.Title = "Rate this app";
            RatePopup.Content = "Your feedback help me improve this app. If you like it, please, rate with 5 star so, that way, I continue to create new functions and updates.";
            RatePopup.ResetLaunchCount();
            RatePopup.CheckRateReminderAsync();
        }
    }
}
