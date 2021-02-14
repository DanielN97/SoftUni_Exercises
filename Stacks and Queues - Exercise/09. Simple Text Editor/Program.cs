using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            Stack<string> stack = new Stack<string>();
            stack.Push(sb.ToString());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    sb.Append(command[1]);
                    stack.Push(sb.ToString());
                }
                else if (command[0] == "2")
                {
                    int elements = int.Parse(command[1]);

                    sb.Remove(sb.Length - elements, elements);

                    stack.Push(sb.ToString());
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);

                    Console.WriteLine(sb[index - 1]);
                }
                else if (command[0] == "4")
                {
                    stack.Pop();
                    sb.Clear();
                    sb.Append(stack.Peek());
                }
            }
        }
    }
}
