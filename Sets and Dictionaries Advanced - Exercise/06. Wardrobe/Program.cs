using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> collection = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!collection.ContainsKey(color))
                {
                    collection.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!collection[color].ContainsKey(clothes[j]))
                    {
                        collection[color].Add(clothes[j], 0);
                    }

                    collection[color][clothes[j]]++;
                }
            }

            string[] wanted = Console.ReadLine().Split();

            foreach (var color in collection)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var element in color.Value)
                {
                    Console.Write($"* {element.Key} - {element.Value}");

                    if (color.Key == wanted[0] && element.Key == wanted[1])
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
