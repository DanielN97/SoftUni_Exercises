using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            int leftCounter = 0;
            int rightCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                    leftCounter++;
                }
                else if (input[i] == ')')
                {
                    rightCounter++;

                    if (stack.Count > 0 && stack.Pop() != '(')
                    {
                    Console.WriteLine("NO");
                    return;
                    }
                }
                else if (input[i] == ']')
                {
                    rightCounter++;

                    if (stack.Count > 0 && stack.Pop() != '[')
                    {
                    Console.WriteLine("NO");
                    return;
                    }
                }
                else if (input[i] == '}')
                {
                    rightCounter++;

                    if (stack.Count > 0 && stack.Pop() != '{')
                    {
                    Console.WriteLine("NO");
                    return;
                    }
                }
            }

            if (leftCounter == rightCounter)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
