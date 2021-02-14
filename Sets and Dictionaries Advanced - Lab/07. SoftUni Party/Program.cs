using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regularGuests = new HashSet<string>();
            HashSet<string> vipGuests = new HashSet<string>();

            string guest = Console.ReadLine();

            while (guest != "PARTY")
            {
                if (char.IsDigit(guest[0]))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }

                guest = Console.ReadLine();
            }

            string guestComming = Console.ReadLine();

            while (guestComming != "END")
            {
                if (char.IsDigit(guestComming[0]) && vipGuests.Contains(guestComming))
                {
                    vipGuests.Remove(guestComming);
                }
                else
                {
                    if (regularGuests.Contains(guestComming))
                    {
                        regularGuests.Remove(guestComming);
                    }
                }

                guestComming = Console.ReadLine();
            }

            Console.WriteLine($"{regularGuests.Count + vipGuests.Count}");

            foreach (string guestMissing in vipGuests)
            {
                Console.WriteLine(guestMissing);
            }
            foreach (string guestMissing in regularGuests)
            {
                Console.WriteLine(guestMissing);
            }
        }
    }
}
