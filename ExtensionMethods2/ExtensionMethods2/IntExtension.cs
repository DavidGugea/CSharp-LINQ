using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods2
{
    public static class IntExtension
    {
        public static int add(this int instance, int num)
        {
            return instance + num;
        }
        public static int minus(this int instance, int num)
        {
            return instance - num;
        }
        public static int multiply(this int instance, int num)
        {
            return instance * num;
        }
        public static int divide(this int instance, int num)
        {
            return instance / num;
        }
        public static void test(this int instance)
        {
            Console.WriteLine("The given int instance is -- > {0}", instance);

            if(instance < 0)
            {
                Console.WriteLine("The instance is smaller than 0");
            }
            else
            {
                Console.WriteLine("The instance is bigger than 0");
            }
        }
    }
}
