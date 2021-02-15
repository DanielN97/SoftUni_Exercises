using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>[]> vloggersAndFollowers = new Dictionary<string, List<string>[]>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {
                string firstName = input[0];
                string action = input[1];
                string secondName = input[2];

                if (action == "joined")
                {
                    if (!vloggersAndFollowers.ContainsKey(firstName))
                    {
                        vloggersAndFollowers.Add(firstName, new List<string>[2]);
                        vloggersAndFollowers[firstName][0] = new List<string>();
                        vloggersAndFollowers[firstName][1] = new List<string>();
                    }
                }
                else if (action == "followed" && vloggersAndFollowers.ContainsKey(firstName) && vloggersAndFollowers.ContainsKey(secondName) && firstName != secondName)
                {
                    if (!vloggersAndFollowers[secondName][0].Contains(firstName))
                    {
                        vloggersAndFollowers[secondName][0].Add(firstName);
                        vloggersAndFollowers[firstName][1].Add(secondName);
                    }
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggersAndFollowers.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in vloggersAndFollowers.OrderByDescending(x => x.Value[0].Count).ThenBy(x => x.Value[1].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value[0].Count} followers, {vlogger.Value[1].Count} following");

                if (counter == 1)
                {
                    vlogger.Value[0].Sort();

                    foreach (string follower in vlogger.Value[0])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}
