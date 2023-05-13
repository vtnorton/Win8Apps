using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vtnorton.Code
{
    public class Util
    {
        private DateTime ParseDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
                return result;
            else
                return DateTime.MinValue;
        }
    }
}
