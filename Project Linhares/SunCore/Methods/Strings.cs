using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunCore.Methods
{
    public class Strings
    {
        public static string FistUppercaseAllWords(String StringToWork)
        {
            string strResult = "";
            bool booPrimeira = true;
            if (StringToWork.Length > 0)
            {
                for (int intCont = 0; intCont <= StringToWork.Length - 1; intCont++)
                {
                    if ((booPrimeira) && (!StringToWork.Substring(intCont, 1).Equals(" ")))
                    {
                        strResult += StringToWork.Substring(intCont, 1).ToUpper();
                        booPrimeira = false;
                    }
                    else
                    {
                        strResult += StringToWork.Substring(intCont, 1).ToLower();
                        if (StringToWork.Substring(intCont, 1).Equals(" "))
                        {
                            booPrimeira = true;
                        }
                    }
                }
            }
            return strResult.Trim();
        }
    }
}
