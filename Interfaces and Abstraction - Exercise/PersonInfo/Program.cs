using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    buyers[input[0]] = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                }
                else if (input.Length == 3)
                {
                    buyers[input[0]] = new Rebel(input[0], int.Parse(input[1]), input[2]);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                if (buyers.ContainsKey(name))
                {
                    IBuyer currentBuyer = buyers[name];
                    currentBuyer.BuyFood();
                }
            }

            Console.WriteLine(buyers.Values.Sum(x => x.Food));
        }
    }
}
