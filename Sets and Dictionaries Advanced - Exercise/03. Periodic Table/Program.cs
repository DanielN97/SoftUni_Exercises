using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> uniqueElements = new SortedSet<string>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (string element in input)
                {
                    uniqueElements.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ", uniqueElements));
        }
    }
}
