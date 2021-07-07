using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(numbers, 0));
        }

        private static long Sum(int[] numbers, int index)
        {
            long sum = 0;

            if (index == numbers.Length)
            {
                return sum;
            }

            sum += numbers[index] + Sum(numbers, ++index);

            return sum;
        }
    }
}
