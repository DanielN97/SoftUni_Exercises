using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (char.IsDigit(input[0]) && vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                if (!char.IsDigit(input[0]) && regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            foreach (var item in vipGuests)
            {
                Console.WriteLine(item);
            }

            foreach (var item in regularGuests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
