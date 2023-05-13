namespace ProjectQuebec.Code
{
    public class Information
    {
        private static string Stage = "Production";
        private static string Branche = "master";
        private static string MajorVersion = "3";
        //Year + Month
        private static string ReleaseDate = "1710";
        //git rev-list --all --count
        private static string Revision = "371";

        public static string Version()
        {
            string _version = MajorVersion + "." + ReleaseDate + "." + Revision;
            if (Stage == "Production")
                return _version;
            else
                return _version + " @" + Branche;
        }
    }
}
