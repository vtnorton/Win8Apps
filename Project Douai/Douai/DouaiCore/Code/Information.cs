using System;

namespace DouaiCore.Code
{
    public static class Information
    {
        //Open command prompt
        //git rev-list --all --count
        public static int RevisonsCount = 53;
        public static string Build = "000";
        public static string VersionWin10 = "5.1703." + RevisonsCount + "." + Build;
        //Mudar manualmente em About.xaml.cs em DouaiWP e DouaiWP Full
        public static string VersionWin8 = "3.1703." + RevisonsCount + "." + Build;
        ///TODO: Adicionar link para download
        public static Uri DownloadWin8FullApp = new Uri("https://www.microsoft.com/store/apps/9n4h0j0cn6vc");
    }
}
