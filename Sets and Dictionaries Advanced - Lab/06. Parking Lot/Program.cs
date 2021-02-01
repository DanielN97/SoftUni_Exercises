using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    set.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    set.Remove(input[1]);
                }

                input = Console.ReadLine().Split(", ");
            }

            if (set.Count > 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
