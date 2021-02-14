using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> evenNumbers = new List<int>();

            Queue<int> queue = new Queue<int>(input);

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    evenNumbers.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
