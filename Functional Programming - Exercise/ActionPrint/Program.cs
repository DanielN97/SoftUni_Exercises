using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Action<string> printer = x => Console.WriteLine(x);

            foreach (string name in input)
            {
                printer(name);
            }
        }
    }
}
