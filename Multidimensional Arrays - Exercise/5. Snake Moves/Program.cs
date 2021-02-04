using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[dimentions[0], dimentions[1]];

            string input = Console.ReadLine();
            Queue<char> queue = new Queue<char>(input);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char temp = queue.Peek();
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(temp);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        char temp = queue.Peek();
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(temp);
                    }
                }

                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    Console.Write(matrix[row, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
