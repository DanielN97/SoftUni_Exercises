using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            int[] numbers = Enumerable.Range(1, endRange).ToArray();

            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> filter = (x, divider) => x % divider == 0;

            foreach (int number in numbers)
            {
                if (dividers.All(d => filter(number, d)))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
