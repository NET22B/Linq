using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var persons = GetPersons().ToList();
           persons.AddOwnMethod(); 
            
           var persons2 = GetPersons();
           persons2.AddOwnMethod(); 
            
            var persons3 = GetPersons().ToArray();
           persons3.AddOwnMethod();

           var p = persons.ToList()[0];
           p.AddYears(5);

            int x = 5;
            x.Print();

        }


        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Lisa",   45),
                new("Sophia-Magdalena", 32),
            };
        }

    }
}
