using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Func<double, double> vatAdder = x => x * 1.2;

            foreach (double number in input)
            {
                Console.WriteLine($"{vatAdder(number):f2}");
            }
        }
    }
}
