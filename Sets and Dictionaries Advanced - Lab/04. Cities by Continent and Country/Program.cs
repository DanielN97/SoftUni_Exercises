using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary.Add(input[0], new Dictionary<string, List<string>>());
                }

                if (!dictionary[input[0]].ContainsKey(input[1]))
                {
                    dictionary[input[0]].Add(input[1], new List<string>());
                }

                dictionary[input[0]][input[1]].Add(input[2]);
            }

            foreach (var continent in dictionary)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
