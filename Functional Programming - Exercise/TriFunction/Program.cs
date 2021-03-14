using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> predicate = (string name, int x) =>
            {
                int sum = 0;

                foreach (char character in name)
                {
                    sum += (int)character;
                }

                return sum >= x;
            };

            Console.WriteLine(names.First(x => predicate(x, number)));
        }
    }
}
