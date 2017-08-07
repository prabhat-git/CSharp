using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equality
{
    public class Program
    {
        public struct Person
        {
            public string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }

            public override string ToString()
            {

                return Name;
            }
            public static bool operator ==(Person p1, Person p2)
            {
                return Equals(p1, p2);
            }
            public static bool operator !=(Person p1, Person p2)
            {
                return !Equals(p1, p2);
            }
        }
        public static void Main(string[] args)
        {
                Person p1 = new Person("Ehsan Sajjad");
                Person p2 = new Person("Ehsan Sajjad");

                Console.WriteLine(p1.Equals(p2));
                Console.WriteLine(p1 == p2);
                Console.ReadKey();
        }
    }
}
