using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HidraOnline.code
{
    public class Methods
    {
        public static String LenghtCount(int xLenghtString, int MaxLenght)
        {
            if (xLenghtString == 1)
                return xLenghtString + " caracter";
            else if (xLenghtString >= MaxLenght)
                return xLenghtString + " caracteres | <strong>Reduza para "+ MaxLenght + " caracteres!</strong>";
            else
                return xLenghtString + " caracteres";
        }
    }
}