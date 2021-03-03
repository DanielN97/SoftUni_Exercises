using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);

            int[] input = Console.ReadLine().Split(", ").Select(parser).ToArray();

            Func<int[], int> summing = x => x.Sum();
            Func<int[], int> counting = x => x.Length;

            Console.WriteLine(counting(input));
            Console.WriteLine(summing(input));
        }
    }
}
