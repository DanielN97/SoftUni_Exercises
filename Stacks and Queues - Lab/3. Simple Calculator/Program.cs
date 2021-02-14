using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            int sum = int.Parse(stack.Pop());

            while (stack.Count > 0)
            {
                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    sum += int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    sum -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(sum);
        }
    }
}
