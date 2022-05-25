using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {

        internal static void AddYears(this Person person, int years)
        {
            person.Age += years;
        } 
        
        internal static void AddOwnMethod(this List<Person> persons)
        {

        }  
        
        internal static void AddOwnMethod(this IEnumerable<Person> persons)
        {

        }

        internal static void Print(this int num) => Console.WriteLine(num);
    }
}
