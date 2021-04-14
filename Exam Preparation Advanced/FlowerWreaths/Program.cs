using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> liliesStack = new Stack<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());
            Queue<int> rosesStack = new Queue<int>(Console.ReadLine().Split(",").Select(int.Parse).ToArray());

            int wreathsCount = 0;

            int flowersLeft = 0;

            while (liliesStack.Count > 0 && rosesStack.Count > 0)
            {
                int currentLilies = liliesStack.Pop();
                int currentRoses = rosesStack.Dequeue();

                int[] output =  FlowersChecker(currentLilies, currentRoses, wreathsCount, flowersLeft);

                wreathsCount = output[0];
                flowersLeft = output[1];
            }

            wreathsCount += flowersLeft / 15;

            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }
        }

        static int[] FlowersChecker(int currentLilies, int currentRoses, int wreathsCount, int flowersLeft)
        {
            if (currentLilies + currentRoses < 15)
            {
                flowersLeft += currentRoses + currentLilies;
            }
            else if (currentLilies + currentRoses == 15)
            {
                wreathsCount++;
            }
            else
            {
                currentLilies -= 2;

                int[] output = FlowersChecker(currentLilies, currentRoses, wreathsCount, flowersLeft);

                wreathsCount = output[0];
                flowersLeft = output[1];
            }

            return new int[] { wreathsCount, flowersLeft };
        }
    }
}
