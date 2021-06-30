using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                Person person = new Person(input[0], int.Parse(input[1]), input[2]);

                people.Add(person);

                input = Console.ReadLine().Split();
            }

            int personToFind = int.Parse(Console.ReadLine());

            int equalPeopleCounter = 0;

            foreach (Person currentPerson in people)
            {
                if (people[personToFind - 1].CompareTo(currentPerson) == 0)
                {
                    equalPeopleCounter++;
                }
            }

            if (equalPeopleCounter == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeopleCounter} {people.Count - equalPeopleCounter} {people.Count}");
            }
        }
    }
}
