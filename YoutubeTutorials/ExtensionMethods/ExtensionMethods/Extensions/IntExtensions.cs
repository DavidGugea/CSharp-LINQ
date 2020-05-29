using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    public static class IntExtensions
    {
        public static bool IsBetween(this int number, int inclusiveLower, int inclusiveUpper)
        {
            return number >= inclusiveLower && number <= inclusiveUpper;
        }
    }

    public static class StringExtensions
    {
        public static bool EqualsIns(this string a, string b)
        {
            return a.Equals(b, StringComparison.OrdinalIgnoreCase);
        }
    }
}