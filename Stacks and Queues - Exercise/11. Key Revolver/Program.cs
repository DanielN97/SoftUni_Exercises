using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int money = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);

            int counter = 0;

            while (stack.Count > 0 && queue.Count > 0)
            {
                if (stack.Pop() <= queue.Peek())
                {
                    queue.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                money -= bulletPrice;
                counter++;

                if (counter == barrelSize)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                    }

                    counter = 0;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${money}");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}
