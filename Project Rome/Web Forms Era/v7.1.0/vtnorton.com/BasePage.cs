using System;
using System.Globalization;
using System.Threading;

namespace VTNORTON
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            if (!string.IsNullOrEmpty(Request["lang"]))
                Session["lang"] = Request["lang"];
            string lang = Convert.ToString(Session["lang"]);
            string culture = string.Empty;

            if (lang.ToLower().CompareTo("en") == 0 || string.IsNullOrEmpty(culture))
                culture = "en-US";
            if (lang.ToLower().CompareTo("pt") == 0)
                culture = "pt";

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            base.InitializeCulture();
        }
    }

}