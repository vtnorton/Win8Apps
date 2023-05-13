using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton
{
    public class FTPPublishProfile
    {
        public static String ProfileName = "vtnorton - FTP";
        public static String PublishMethod = "FTP";
        public static String PublishUrl = "ftp://waws-prod-cq1-001.ftp.azurewebsites.windows.net/site/wwwroot";
        public static String FtpPassiveMode = "True";
        public static String UserName = "vtnorton\\$vtnorton";
        public static String UserPWD = "igN9psQu8zwrquKAJqWDDp9qBPb7xjK664lx4TErjejshgJ51h1GaHvsi8RC";
        public static String DestinationAppUrl = "http://vtnorton.azurewebsites.net";
    }
}
