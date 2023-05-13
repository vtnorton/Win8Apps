using System.Globalization;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace ProjectQuebec.Code.Util
{
    public class ColorBrush
    {
        public static Color Gray = HexToColor("#CCCCCC");
        public static Color LightGray = HexToColor("#F2F2F2");
        public static Color Blue = HexToColor("#16499A");
        public static SolidColorBrush SolidColorBrushGray = new SolidColorBrush(Gray);
        public static SolidColorBrush SolidColorBrushLightGray = new SolidColorBrush(LightGray);
        public static SolidColorBrush SolidColorBrushBlue = new SolidColorBrush(Blue);

        public static Color HexToColor(string Hex)
        {
            string hexCode = Hex.Replace("#", "");
            var color = new Color();
            color.A = 255;
            color.R = byte.Parse(hexCode.Substring(0, 2), NumberStyles.HexNumber);
            color.G = byte.Parse(hexCode.Substring(2, 2), NumberStyles.HexNumber);
            color.B = byte.Parse(hexCode.Substring(4, 2), NumberStyles.HexNumber);
            return color;
        }
    }
}
