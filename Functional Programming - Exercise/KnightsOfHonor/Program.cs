using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> sirAppender = x => Console.WriteLine($"Sir {x}");

            Action<string[]> printer = x =>
            {
                foreach (string name in input)
                {
                    sirAppender(name);
                }
            };

            printer(input);
        }
    }
}
