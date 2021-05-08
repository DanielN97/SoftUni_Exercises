using System;

namespace Tuple
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstDataSet = Console.ReadLine().Split();
            string[] secondDataSet = Console.ReadLine().Split();
            string[] thirdDataSet = Console.ReadLine().Split();

            Tuple<string, string> firstTuple = new Tuple<string, string>($"{firstDataSet[0]} {firstDataSet[1]}", firstDataSet[2]);
            Tuple<string, int> secondTuple = new Tuple<string, int>(secondDataSet[0], int.Parse(secondDataSet[1]));
            Tuple<int, double> thirdTuple = new Tuple<int, double>(int.Parse(thirdDataSet[0]), double.Parse(thirdDataSet[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
