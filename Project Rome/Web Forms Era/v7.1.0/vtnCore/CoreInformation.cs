namespace vtnCore
{
    public class CoreInformation
    {
        public static string BuildInfo = "v1.0.0 (alpha)";
        public static string ConnectionString = WhatConnectionToUse();
        public static string ConnectionStringSurafePro = "";

        private static string WhatConnectionToUse()
        {
            return @"Data Source=OROCHIMARU-PC\SQLEXPRESS;Initial Catalog=vtnorton;Integrated Security=True";
        }

    }
}