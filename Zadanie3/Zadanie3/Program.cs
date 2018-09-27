using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Arek", 28));
            persons.Add(new Person("John", 18));
            persons.Add(new Person("Daniel", 50));
            persons.Add(new Person("Maciej", 10));


            Person.PrintOccurrenceOfGivenAge(persons, 18);
            persons.Sort();
            foreach (Person p in persons)
            {
                if (p.Age >= 18)
                    Console.WriteLine(p.Age);
            }
            Console.ReadKey();
        }
    }
}
