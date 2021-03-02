using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[] output = input.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(", ", output)); ;
        }
    }
}
