using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            Queue<int[]> copy = new Queue<int[]>(queue);

            int petrol = 0;
            int counter = 0;
            int station = 0;

            while (petrol >= 0)
            {
                int[] currentStation = queue.Dequeue();

                petrol += currentStation[0];
                petrol -= currentStation[1];

                if (petrol < 0)
                {
                    station++;
                    counter = 0;
                    petrol = 0;

                    copy.Enqueue(copy.Dequeue());
                    queue.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        int[] currentCopy = copy.Dequeue();
                        queue.Enqueue(currentCopy);
                        copy.Enqueue(currentCopy);
                    }
                }
                else
                {
                    counter++;
                    if (counter == n)
                    {
                        Console.WriteLine(station);
                        break;
                    }
                }
            }
        }
    }
}
