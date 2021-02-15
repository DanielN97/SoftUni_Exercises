using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dataBase = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string colour = input[0];
                string[] items = input[1].Split(",");

                if (!dataBase.ContainsKey(colour))
                {
                    dataBase.Add(colour, new Dictionary<string, int>());
                }

                foreach (string item in items)
                {
                    if (!dataBase[colour].ContainsKey(item))
                    {
                        dataBase[colour].Add(item, 0);
                    }

                    dataBase[colour][item]++;
                }
            }

            string[] itemToFind = Console.ReadLine().Split();

            foreach (var colour in dataBase)
            {
                Console.WriteLine($"{colour.Key} clothes:");

                foreach (var item in colour.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");

                    if (colour.Key == itemToFind[0] && item.Key == itemToFind[1])
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
