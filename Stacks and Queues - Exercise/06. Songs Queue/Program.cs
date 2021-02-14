using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(input);

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.Substring(0, 4) == "Play")
                {
                    queue.Dequeue();
                }
                else if (command.Substring(0, 3) == "Add")
                {
                    if (queue.Contains(command.Substring(4)))
                    {
                        Console.WriteLine($"{command.Substring(4)} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(command.Substring(4));
                    }
                }
                else
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
