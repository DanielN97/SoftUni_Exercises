using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataBase = new HashSet<string>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                string name = Console.ReadLine();

                dataBase.Add(name);
            }

            foreach (string name in dataBase)
            {
                Console.WriteLine(name);
            }
        }
    }
}
