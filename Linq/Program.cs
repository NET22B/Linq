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


            var persons5 = GetPersons();
            var result = persons5.Where(p => p.Age > 20).ToList();
            var result2 = persons5.Where(IsOver20).ToList();

            List<Person> res = new List<Person>();
            foreach (var perso in GetPersons())
            {
                if(perso.Age > 20)
                    res.Add(perso);
            }

            var pers9 = GetPersons();
            var res5 = persons5.Where(p => p.Name.Length > 10)
                               .Where(IsOver20)
                               .Select(p => new PersonDto
                               {
                                   Name = p.Name,
                                   NamesLength = p.Name.Length
                               });

            var firstPelle = pers9.FirstOrDefault(p => p.Name.Equals("Pelle"));

            var ints = Enumerable.Range(1, 100).ToArray();

            var sum2 = ints.Predicate(i => i > 0).Sum();

            var sum = ints.Where(i => i > 10).Sum();

            var allPelle = pers9.Where(p => p.Name.Equals("Pelle"));
            var allPelle2 = pers9.Predicate(p => p.Name.Equals("Pelle"));
            var allPelle3 = pers9.Predicate(p => p.Name.StartsWith("P"));
            var allPelle4 = pers9.Predicate(p => p.Age < 50);
            var allPelle5 = pers9.Predicate(IsOver20);
            var allPelle6 = pers9.Predicate(p => IsOver20(p));

            
                               

            Console.ReadKey();

        }

        private static bool IsOver20(Person p)
        {
            return p.Age > 20;
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
