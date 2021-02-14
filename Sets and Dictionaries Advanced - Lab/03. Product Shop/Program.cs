using System;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dataBase = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!dataBase.ContainsKey(shop))
                {
                    dataBase.Add(shop, new Dictionary<string, double>());
                }

                dataBase[shop].Add(product, price);

                input = Console.ReadLine().Split(", ");
            }

            foreach (var shop in dataBase)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var productData in shop.Value)
                {
                    Console.WriteLine($"Product: {productData.Key}, Price: {productData.Value}");
                }
            }
        }
    }
}
