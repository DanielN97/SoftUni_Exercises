using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dataBase = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dataBase.ContainsKey(continent))
                {
                    dataBase.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dataBase[continent].ContainsKey(country))
                {
                    dataBase[continent].Add(country, new List<string>());
                }

                dataBase[continent][country].Add(city);
            }

            foreach (var continent in dataBase)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
