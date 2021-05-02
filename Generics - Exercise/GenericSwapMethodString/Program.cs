using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());

                list.Add(box);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SwapTwoElements(list, indexes[0], indexes[1]);

            foreach (Box<string> currentBox in list)
            {
                Console.WriteLine(currentBox);
            }
        }

        private static void SwapTwoElements<T>(List<Box<T>> list, int firstIndex, int secondIndex)
        {
            Box<T> firstElement = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstElement;
        }
    }
}
