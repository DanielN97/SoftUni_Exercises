using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodString
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

            Box<string> itemToCompare = new Box<string>(Console.ReadLine());

            Console.WriteLine(GetGreaterThanCount(list, itemToCompare));
        }

        private static int GetGreaterThanCount<T>(List<Box<T>> boxes, Box<T> box)
            where T : IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                if (item.Value.CompareTo(box.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
