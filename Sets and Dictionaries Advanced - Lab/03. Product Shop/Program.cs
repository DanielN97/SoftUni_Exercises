using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            SortedDictionary<string, Dictionary<string, double>> dictionary = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                if (!dictionary.ContainsKey(input[0]))
                {
                    dictionary.Add(input[0], new Dictionary<string, double>());
                }

                if (!dictionary[input[0]].ContainsKey(input[1]))
                {
                    dictionary[input[0]].Add(input[1], double.Parse(input[2]));
                }

                input = Console.ReadLine().Split(", ");
            }

            foreach (var shop in dictionary)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
