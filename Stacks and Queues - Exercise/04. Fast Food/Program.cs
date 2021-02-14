using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());
            while (queue.Count > 0 && foodQuantity >= queue.Peek())
            {
                foodQuantity -= queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else if (queue.Count > 0)
            {
                Console.Write("Orders left: ");

                Console.Write(String.Join(" ", queue));
            }
        }
    }
}
