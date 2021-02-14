using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weights = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            int counter = 0;

            Stack<int> stack = new Stack<int>(weights);

            int currentCapacity = capacity;

            while (stack.Any())
            {
                if (currentCapacity > stack.Peek())
                {
                    currentCapacity -= stack.Pop();
                    if (stack.Count == 0)
                    {
                        counter++;
                    }
                }
                else if (currentCapacity == stack.Peek())
                {
                    stack.Pop();
                    currentCapacity = capacity;
                    counter++;
                }
                else
                {
                    currentCapacity = capacity;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
