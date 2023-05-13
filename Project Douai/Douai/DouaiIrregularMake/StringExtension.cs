using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouaiIrregularMake
{
    public static class StringExtension
    {
        public static string GetBetween(this string strSource, string strStart, string strEnd)
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
        public static string GetBetweenSubjuntivo(this string strSource, string strStart, string strEnd)
        {
            int indexOf = strSource.IndexOf("Subjuntivo", 9);
            string nova;

            nova = strSource.Substring(indexOf);

            return GetBetween(nova, strStart, strEnd);
        }
    }
}
