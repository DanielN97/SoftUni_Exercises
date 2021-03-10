using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> filterForNames = (x, length) => x.Length <= length;

            string[] filteredNames = names.Where(name => filterForNames(name, nameLength)).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, filteredNames));
        }
    }
}
