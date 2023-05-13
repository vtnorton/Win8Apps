using System;
using System.Text;

namespace SunCore.Methods
{
    public class Encode
    {
        public static string Base64Encode(string StringToWork)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(StringToWork);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
