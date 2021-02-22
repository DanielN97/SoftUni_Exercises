using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split();

                Person person = new Person(personData[0], int.Parse(personData[1]));
                people.Add(person);
            }

            foreach (Person person in people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList())
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
