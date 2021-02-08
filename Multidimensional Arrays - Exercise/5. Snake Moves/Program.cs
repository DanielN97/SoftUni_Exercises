using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];

            string snake = Console.ReadLine();

            Queue<char> queue = new Queue<char>(snake);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentChar = queue.Dequeue();
                        matrix[row, col] = currentChar;
                        queue.Enqueue(currentChar);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        FillingMatrix(matrix, queue, row, col);
                    }
                }
            }
        }

        private static void FillingMatrix(int[,] matrix, Queue<char> queue, int row, int col)
        {
            char currentChar = queue.Dequeue();
            matrix[row, col] = currentChar;
            queue.Enqueue(currentChar);
        }
    }
}