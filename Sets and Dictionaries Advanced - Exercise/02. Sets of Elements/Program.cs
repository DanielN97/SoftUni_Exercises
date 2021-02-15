using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLengths = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < setsLengths[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < setsLengths[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> finalSet = firstSet;

            finalSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ", finalSet));
        }
    }
}
