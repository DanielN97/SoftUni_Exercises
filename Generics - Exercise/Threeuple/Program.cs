using System;
using System.Linq;

namespace Threeuple
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] firstDataSet = Console.ReadLine().Split();
            string[] secondDataSet = Console.ReadLine().Split();
            string[] thirdDataSet = Console.ReadLine().Split();

            string town = String.Empty;

            for (int i = 3; i < firstDataSet.Length - 1; i++)
            {
                town += firstDataSet[i] + " ";
            }
            town += firstDataSet[firstDataSet.Length - 1];

            Treeuple<string, string, string> firstTreeuple =
                new Treeuple<string, string, string>($"{firstDataSet[0]} {firstDataSet[1]}", firstDataSet[2], town);
            Treeuple<string, int, bool> secondTreeuple =
                new Treeuple<string, int, bool>(secondDataSet[0], int.Parse(secondDataSet[1]), secondDataSet[2] == "drunk");
            Treeuple<string, double, string> thirdTreeuple =
                new Treeuple<string, double, string>(thirdDataSet[0], double.Parse(thirdDataSet[1]), thirdDataSet[2]);

            Console.WriteLine(firstTreeuple);
            Console.WriteLine(secondTreeuple);
            Console.WriteLine(thirdTreeuple); 
        }
    }
}
