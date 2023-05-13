using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.Methods
{
    public class Strings
    {
        /// <summary>
        /// Ao enviar uma String, o primeiro caractere da primeira palavra se torna maiúscula e toda a string se torna minuscula.
        /// </summary>
        /// <param name="StringToWork">String a ser trabalhada</param>
        /// <returns></returns>
        public static string JustFistUppercase(String StringToWork)
        {
            //Not working
            //string strResult = "";
            //if (StringToWork.Length > 0)
            //{
            //    strResult += StringToWork.Substring(0, 1).ToUpper();
            //}
            return StringToWork.Trim();
        }
        /// <summary>
        /// Ao enviar uma String o primeiro caractere de cada palavra se torna maiúscula.
        /// </summary>
        /// <param name="StringToWork">String a ser trabalhada</param>
        /// <returns></returns>
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
        public static string Base64Encode(string StringToWork)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(StringToWork);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string StringToWork, int LengthString)
        {
            var base64EncodedBytes = Convert.FromBase64String(StringToWork);
            return Encoding.UTF8.GetString(base64EncodedBytes, 0, LengthString);
        }
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
    }
}
