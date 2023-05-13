namespace ProjectRedmonde.Code
{
    public class Information
    {
        private static int MajorVersion = 1;
        private static int Update = 1706;
        private static int Revison = 0;
        private static string Build = "";
        private static string Branche = "master";
        private static string Stage = "Development";

        public static string Version()
        {
            string _version = MajorVersion + "." + Update + "." + Revison;
            if (Stage == "Production")
                return _version;
            else
                return _version + "." + Build + " @" + Branche;
        }
    }
}
