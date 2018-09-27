using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    public class Person : IComparable<Person>
    {
        private string v1;
        private int v2;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        internal static void PrintAscending(ICollection<Person> collection)
        {



        }

        internal static void PrintOccurrenceOfGivenAge(ICollection<Person> collection, int age)
        {
            bool found = false;
            foreach (Person osoba in collection)
            {
                if (osoba.Age == age)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found);
        }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age)
                return -1;
            else if (this.Age < other.Age)
                return 1;
            else return 0;

        }
    }
}
