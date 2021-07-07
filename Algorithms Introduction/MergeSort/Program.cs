using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = Mergesort.mergeSort(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
