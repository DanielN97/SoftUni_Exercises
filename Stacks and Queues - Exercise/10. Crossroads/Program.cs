using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeDuration = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string input = Console.ReadLine();

            int carsPassed = 0;

             while (input != "END")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int greenLeft = greenDuration;

                    while (greenLeft > 0)
                    {
                        if (queue.Count > 0)
                        {
                            string currentCar = queue.Dequeue();

                            if (greenLeft > currentCar.Length)
                            {
                                greenLeft -= currentCar.Length;
                                carsPassed++;

                                if (queue.Count == 0)
                                {
                                    break;
                                }
                            }
                            else if (greenLeft == currentCar.Length)
                            {
                                greenLeft -= currentCar.Length;
                                carsPassed++;
                            }
                            else
                            {
                                if (freeDuration < currentCar.Length - greenLeft)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[greenLeft + freeDuration]}.");
                                    return;
                                }
                                else
                                {
                                    carsPassed++;
                                    greenLeft = 0;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
        }
    }
}
