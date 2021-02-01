using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int bestSum = 0;
            int[] bestIndex = new int[2];
            int[,] bestMatrix = new int[3, 3];

            if (dimentions[0] > 2 && dimentions[1] > 2)
            {
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        int currentSum = 0;

                        for (int i = row; i < row + 3; i++)
                        {
                            for (int j = col; j < col + 3; j++)
                            {
                                currentSum += matrix[i, j];
                            }
                        }

                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            bestIndex[0] = row;
                            bestIndex[1] = col;
                        }
                    }
                }

                for (int row = 0; row < bestMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < bestMatrix.GetLength(1); col++)
                    {
                        bestMatrix[row, col] = matrix[bestIndex[0] + row, bestIndex[1] + col];
                    }
                }

                Console.WriteLine($"Sum = {bestSum}");

                for (int row = 0; row < bestMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < bestMatrix.GetLength(1) - 1; col++)
                    {
                        Console.Write(bestMatrix[row, col] + " ");
                    }
                    Console.Write(bestMatrix[row, bestMatrix.GetLength(1) - 1]);
                    Console.WriteLine();
                }
            }
        }
    }
}
