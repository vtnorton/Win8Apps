using Windows.Storage;

namespace ProjectQuebec.Code
{
    public class EditorCSS
    {
        public static string CssToInclude()
        {
            string Font = ApplicationData.Current.LocalSettings.Values["font"]?.ToString();
            string FontSize = ApplicationData.Current.LocalSettings.Values["font-size"]?.ToString();
            
            string CssToChange = ".CodeMirror {";

            #region CODEMIRROR
            if (Font != null)
                CssToChange += "font-family: '" + Font + "' !important;";

            if (FontSize != null)
                CssToChange += "font-size: " + FontSize + "px !important;";
            #endregion

            CssToChange += "}";

            return CssToChange;
        }
    }
}
