using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int key = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.IndexOf(arr, key));
        }
    }
}
