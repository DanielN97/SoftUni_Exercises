using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (int number in input)
            {
                stack.Push(number);
            }

            string[] command = Console.ReadLine().Split();
            while (command[0].ToLower() != "end")
            {
                string lowerCommand = command[0].ToLower();
                if (lowerCommand == "add")
                {
                    for (int i = 1; i < 3; i++)
                    {
                        stack.Push(int.Parse(command[i]));
                    }
                }
                else if (lowerCommand == "remove" && stack.Count >= int.Parse(command[1]))
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        stack.Pop();
                    }
                }

                command = Console.ReadLine().Split();
            }

            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
