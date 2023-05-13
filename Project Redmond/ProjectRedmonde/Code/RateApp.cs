using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversalRateReminder;

namespace ProjectRedmonde.Code
{
    public class RateApp
    {
        public static void RateThisApp()
        {
            RatePopup.LaunchLimit = 3;
            RatePopup.ResetCountOnNewVersion = true;
            RatePopup.RateButtonText = "Rate 5 stars";
            RatePopup.CancelButtonText = "No, thanks";
            RatePopup.Title = "Rate this app";
            RatePopup.Content = "You can help make this app better by rating it.";
            RatePopup.ResetLaunchCount();
            RatePopup.CheckRateReminderAsync();

        }
    }
}
