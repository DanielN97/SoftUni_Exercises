using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = 0;
                    int currentRow = row;
                    int currentCol = col;

                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = currentRow;
                        bestCol = bestCol;
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int row = bestRow; row < bestRow + 3; row++)
            {
                Console.WriteLine(matrix[row, bestCol] + " " + matrix[row, bestCol + 1] + " " + matrix[row, bestCol + 2]);
            }
        }
    }
}
