using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVtnorton.Email
{
    public class JadeAccount
    {        
        public static int Port = 587;
        public static bool UseDefaultCredentials = false;
        public static bool EnableSsl = true;
        public static bool IsBodyHtml = true;
        public static String Host = "smtp.gmail.com";
        public static String From = "contato@vtnorton.com";
        public static String Email = "jade@vtnorton.com";
        public static String Password = "";

        //Strings.Base64Decode("amFkZUB2dG5vcnRvbi5jb20==", 17)
        //Strings.Base64Decode("TG9zdDQ4MTUxNjIzNDI=", 14)
    }
}
