using System;
using System.Collections.Generic;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> dataBase = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                dataBase.Add(name, age);
            }

            string condition = Console.ReadLine();
            int ageToFind = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, ageToFind);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(printFormat);

            foreach (var person in dataBase)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        public static Func<int, bool> CreateTester(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x < age;
            }
            else
            {
                return x => x >= age;
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return x => Console.WriteLine($"{x.Key}");
            }
            else if (format == "age")
            {
                return x => Console.WriteLine($"{x.Value}");
            }

            return x => Console.WriteLine($"{x.Key} - {x.Value}");
        } 
    }
}
