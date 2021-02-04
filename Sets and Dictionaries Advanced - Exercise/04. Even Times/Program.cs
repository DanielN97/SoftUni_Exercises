using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>(); ;

            int n = int.Parse(Console.ReadLine());

            int finalNumber = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number]++;
                }
            }

            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    finalNumber = item.Key;
                }
            }

            Console.WriteLine(finalNumber);
        }
    }
}
