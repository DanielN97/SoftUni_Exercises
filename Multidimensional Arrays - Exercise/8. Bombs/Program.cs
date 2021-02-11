using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] input = Console.ReadLine().Split();

            int currentBombRow = -1;
            int currentBombCol = -1;

            foreach (string item in input)
            {
                int[] coordinates = item.Split(',').Select(int.Parse).ToArray();

                currentBombRow = coordinates[0];
                currentBombCol = coordinates[1];

                int bombPower = matrix[currentBombRow, currentBombCol];

                if (bombPower > 0)
                {
                    if (currentBombRow == 0 && currentBombCol == 0)
                    {
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol + 1] -= bombPower;
                        }
                    }
                    else if (currentBombRow == 0 && currentBombCol == matrix.GetLength(1) - 1)
                    {
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                    }
                    else if (currentBombRow == matrix.GetLength(0) - 1 && currentBombCol == 0)
                    {
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                    }
                    else if (currentBombRow == matrix.GetLength(0) - 1 && currentBombCol == matrix.GetLength(1) - 1)
                    {
                        if (matrix[currentBombRow - 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                    }
                    else if (currentBombRow == 0)
                    {
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol + 1] -= bombPower;
                        }
                    }
                    else if (currentBombRow == matrix.GetLength(0) - 1)
                    {
                        if (matrix[currentBombRow - 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                    }
                    else if (currentBombCol == 0)
                    {
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol + 1] -= bombPower;
                        }
                    }
                    else if (currentBombCol == matrix.GetLength(1) - 1)
                    {
                        if (matrix[currentBombRow - 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                    }
                    else
                    {
                        if (matrix[currentBombRow - 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow - 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow - 1, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow, currentBombCol + 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol - 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol - 1] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol] -= bombPower;
                        }
                        if (matrix[currentBombRow + 1, currentBombCol + 1] > 0)
                        {
                            matrix[currentBombRow + 1, currentBombCol + 1] -= bombPower;
                        }
                    }

                    matrix[currentBombRow, currentBombCol] = 0;
                }
            }

            int aliveCells = 0;
            int aliveSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        aliveSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveSum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
