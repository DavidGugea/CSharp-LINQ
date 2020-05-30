using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class IntExtensions
    {
        public static int Multiply(this int instanz, int faktor)
        {
            return instanz * faktor;
        }
        public static int Abs(this int instanz)
        {
            if(instanz < 0)
            {
                return -1 * instanz;
            }

            return instanz;
        }
    }
}
