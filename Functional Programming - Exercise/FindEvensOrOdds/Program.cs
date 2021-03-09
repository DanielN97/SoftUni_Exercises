using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int lowerBound = range[0];
            int upperBound = range[1];

            string filterCommand = Console.ReadLine();

            Predicate<int> filter = x => true;

            if (filterCommand == "even")
            {
                filter = x => x % 2 == 0;
            }
            else if (filterCommand == "odd")
            {
                filter = x => x % 2 != 0;
            }

            List<int> filteredNumbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (filter(i))
                {
                    filteredNumbers.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", filteredNumbers));
        }
    }
}
