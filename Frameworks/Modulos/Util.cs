using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Modulos
{
    public static  class UtilFramework
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }


    }
}
