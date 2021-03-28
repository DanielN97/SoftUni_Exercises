using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }

                try
                {
                    if (input[0] == "Add")
                    {
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            continue;
                        }

                        Player player = new Player(input[2], int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));

                        teams[input[1]].AddPlayer(player);
                    }
                    else if (input[0] == "Remove")
                    {
                        teams[input[1]].RemovePlayer(input[2]);
                    }
                    else if (input[0] == "Rating")
                    {
                        if (!teams.ContainsKey(input[1]))
                        {
                            Console.WriteLine($"Team {input[1]} does not exist.");
                            continue;
                        }

                        Console.WriteLine($"{input[1]} - {teams[input[1]].Rating}");
                    }
                    else if (input[0] == "Team")
                    {
                        Team team = new Team(input[1]);

                        teams.Add(team.Name, team);
                    }
                }
                catch (Exception exeption) when(exeption is ArgumentException || exeption is InvalidOperationException)
                {
                    Console.WriteLine(exeption.Message);
                }
            }
        }
    }
}
