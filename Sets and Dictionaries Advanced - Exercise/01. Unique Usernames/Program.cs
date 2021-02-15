using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
