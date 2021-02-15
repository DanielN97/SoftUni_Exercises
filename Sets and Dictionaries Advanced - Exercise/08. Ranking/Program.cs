using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsInfo = new Dictionary<string, string>();

            string[] contestInfo = Console.ReadLine().Split(":");

            while (contestInfo[0] != "end of contests")
            {
                if (!contestsInfo.ContainsKey(contestInfo[0]))
                {
                    contestsInfo.Add(contestInfo[0], contestInfo[1]);
                }

                contestInfo = Console.ReadLine().Split(":");
            }

            Dictionary<string, Dictionary<string, int>> contestantsInfo = new Dictionary<string, Dictionary<string, int>>();

            string[] contestantInfo = Console.ReadLine().Split("=>");

            while (contestantInfo[0] != "end of submissions")
            {
                string contest = contestantInfo[0];
                string password = contestantInfo[1];
                string username = contestantInfo[2];
                int points = int.Parse(contestantInfo[3]);

                if (contestsInfo.ContainsKey(contest) && contestsInfo[contest] == password)
                {
                    if (!contestantsInfo.ContainsKey(username))
                    {
                        contestantsInfo.Add(username, new Dictionary<string, int>());
                    }

                    if (!contestantsInfo[username].ContainsKey(contest))
                    {
                        contestantsInfo[username].Add(contest, points);
                    }

                    if (points > contestantsInfo[username][contest])
                    {
                        contestantsInfo[username][contest] = points;
                    }
                }

                contestantInfo = Console.ReadLine().Split("=>");
            }

            string bestCandidate = string.Empty;
            int bestPoints = 0;

            foreach ((string contestantName, Dictionary<string, int> currentContestant) in contestantsInfo)
            {
                int totalPoints = 0;

                foreach ((string currentContest, int currentPoints) in currentContestant)
                {
                    totalPoints += currentPoints;
                }

                if (totalPoints > bestPoints)
                {
                    bestCandidate = contestantName;
                    bestPoints = totalPoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var contestant in contestantsInfo.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var info in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {info.Key} -> {info.Value}");
                }
            }
        }
    }
}
