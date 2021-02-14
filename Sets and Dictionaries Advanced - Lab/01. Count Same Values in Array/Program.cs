using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dataBase = new Dictionary<double, int>();

            foreach (double num in numbers)
            {
                if (!dataBase.ContainsKey(num))
                {
                    dataBase.Add(num, 0);
                }

                dataBase[num]++;
            }

            foreach (var item in dataBase)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
