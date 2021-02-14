using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataBase = new HashSet<string>();

            string[] command = Console.ReadLine().Split(", ");

            while (command[0] != "END")
            {
                string direction = command[0];
                string registrationNumber = command[1];

                if (direction == "IN")
                {
                    dataBase.Add(registrationNumber);
                }
                else if (direction == "OUT" && dataBase.Contains(registrationNumber))
                {
                    dataBase.Remove(registrationNumber);
                }

                command = Console.ReadLine().Split(", ");
            }

            if (dataBase.Count != 0)
            {
                foreach (string number in dataBase)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
