using System;
using System.Collections.Generic;
using ExtensionMethods.SomeClassLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethods.Extensions
{
    public static class PersonExtension
    {
        public static bool IsOfDrinkingAge(this Person person)
        {
            return person.Age >= Constants.DrinkingAge;
        }
    }
}
