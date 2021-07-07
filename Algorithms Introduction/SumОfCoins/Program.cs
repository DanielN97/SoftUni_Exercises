using System;
using System.Collections.Generic;
using System.Linq;

namespace SumОfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> availableCoins = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).Select(int.Parse).ToList();

            string[] inputSum = Console.ReadLine().Split();

            int targetSum = int.Parse(inputSum[1]);

            try
            {
                
                Dictionary<int, int> selectedCoins = ChooseCoins(availableCoins, targetSum);

                Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");

                foreach (var kvp in selectedCoins)
                {
                    Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Dictionary<int, int> ChooseCoins(List<int> coins, int targetSum)
        {
            Dictionary<int, int> chosenCoins = new Dictionary<int, int>();
            int currentSum = 0;
            int currentIndex = 0;

            coins = coins.OrderByDescending(x => x).ToList();

            while (currentSum != targetSum && currentIndex < coins.Count)
            {
                int currentCoin = coins[currentIndex];
                int remainingSum = targetSum - currentSum;

                int numerOfCoinsTaken = remainingSum / currentCoin;

                if (numerOfCoinsTaken > 0)
                {
                    chosenCoins.Add(currentCoin, numerOfCoinsTaken);

                    currentSum += numerOfCoinsTaken * currentCoin;
                }

                currentIndex++;
            }

            if (currentSum != targetSum || currentIndex > coins.Count)
            {
                throw new Exception("Error");
            }

            return chosenCoins;
        }
    }
}
