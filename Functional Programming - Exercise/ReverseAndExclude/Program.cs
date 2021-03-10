using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int devider = int.Parse(Console.ReadLine());

            Func<int[], int[]> reverser = x =>
            {
                int[] reversedNumbers = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
                }

                return reversedNumbers;
            };

            Predicate<int> filter = x => x % devider != 0;

            int[] reversed = reverser(numbers);

            List<int> filtered = new List<int>();

            foreach (int number in reversed)
            {
                if (filter(number))
                {
                    filtered.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", filtered));
        }
    }
}
