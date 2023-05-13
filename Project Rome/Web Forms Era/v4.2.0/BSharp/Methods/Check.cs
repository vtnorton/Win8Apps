using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BSharp.Methods
{
    public class Check
    {
        private const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                                 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                                 + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
        public static Boolean Email(String strEmail)
        {
            if (strEmail != null) return Regex.IsMatch(strEmail, MatchEmailPattern);
            else return false;
        }
        public static Boolean Password(String strPassword)
        {
            return true;
        }
        public static Boolean Password(String strPassword, int intMin)
        {
            if (strPassword.Length >= intMin)
            {
                return Password(strPassword);
            }else{
                return false;
            }
        }
        public static Boolean Password(String strPassword, int intMin, int intMax)
        {
            if ((strPassword.Length >= intMin) && (strPassword.Length <= intMax))
            {
                return Password(strPassword);
            }
            else
            {
                return false;
            }
        }
    }
}
