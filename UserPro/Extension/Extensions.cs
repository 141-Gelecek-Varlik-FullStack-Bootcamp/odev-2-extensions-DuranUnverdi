using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserPro.Extension
{
    public static class  Extensions
    {
        public static string ConvertDollar(this double variable)
        {
            return variable / 13.5 + "$";
        }

        public static string ConvertEuro(this double variable)
        {
            return variable / 15.0 + "€";
        }
    }
}
