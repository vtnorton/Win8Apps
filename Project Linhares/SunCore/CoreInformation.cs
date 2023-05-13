using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore
{
    public class CoreInformation
    {
        public static int Database = 1; // 1 - para banco de testes, 2 - para banco oficial
        public static int Build = 9;
        public static string BuildInfo = Build.ToString() + " (alpha)";
        public static string SunCore = "0.0." + Build;
        public static string SunWeb = "0.0.0";
        public static string SunWebServicesClassLibrary = "0.0.0";
        public static string SunApp = "0.0.0";
    }
}