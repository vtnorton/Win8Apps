using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton
{
    public class MSDeployPublishProfile
    {
        public static String ProfileName = "vtnorton - Web Deploy";
        public static String PublishMethod = "MSDeploy"; 
        public static String PublishUrl = "vtnorton.scm.azurewebsites.net:443";
        public static String MsdeploySite="vtnorton";
        public static String UserName="$vtnorton";
        public static String UserPWD="igN9psQu8zwrquKAJqWDDp9qBPb7xjK664lx4TErjejshgJ51h1GaHvsi8RC";
        public static String DestinationAppUrl="http://vtnorton.azurewebsites.net";
    }
}
