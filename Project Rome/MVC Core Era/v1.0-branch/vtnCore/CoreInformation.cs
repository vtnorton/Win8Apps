namespace vtnCore
{
    public class CoreInformation
    {
        public static string BuildInfo = "v1.1.0 (alpha)";
        public static string ConnectionString = WhatConnectionToUse();
        public static string ConnectionStringSurafePro = "";

        private static string WhatConnectionToUse()
        {
            //DELL INSPIRON 15R
            return @"Data Source=OROCHIMARU-PC\SQLEXPRESS;Initial Catalog=vtnorton;Integrated Security=True";
        }

    }
}