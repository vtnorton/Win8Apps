namespace vtnCore
{
    public class CoreInformation
    {
        public static string BuildInfo = "v2.0.0 (alpha)";
        public static string ConnectionString = WhatConnectionToUse();
        public static string ConnectionStringSurafePro = "";

        private static string WhatConnectionToUse()
        {
            return "";
        }

    }
}