using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottleCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(bottleCapacity);
            Queue<int> cups = new Queue<int>(cupCapacity);

            int wastedWater = 0;

            bool isFull = false;

            int currentCup = cups.Peek();

            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentBottle = bottles.Pop();

                if (isFull)
                {
                    currentCup = cups.Peek();
                }

                if (currentBottle > currentCup)
                {
                    cups.Dequeue();
                    wastedWater += currentBottle - currentCup;
                    isFull = true;
                }
                else if (currentBottle == currentCup)
                {
                    cups.Dequeue();
                    isFull = true;
                }
                else
                {
                    currentCup -= currentBottle;
                    isFull = false;
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
