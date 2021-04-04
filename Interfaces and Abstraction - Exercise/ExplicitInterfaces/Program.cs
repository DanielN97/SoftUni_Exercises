using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Models;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();

                string name = parts[0];
                string country = parts[1];
                int age = int.Parse(parts[2]);

                Citizen citizen = new Citizen(name, country, age);

                IPerson person = citizen;
                person.GetName();

                IResident resident = citizen;
                resident.GetName();
            }
        }
    }
}
