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
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] bombPositions = Console.ReadLine().Split();

            for (int i = 0; i < bombPositions.Length; i++)
            {
                string[] currentBomb = bombPositions[i].Split(",");
                int rowBomb = int.Parse(currentBomb[0]);
                int colBomb = int.Parse(currentBomb[1]);
                int bombPower = matrix[rowBomb, colBomb];

                if (bombPower > 0)
                {
                    matrix[rowBomb, colBomb] -= bombPower;

                    if (rowBomb == 0)
                    {
                        if (colBomb == 0)
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                        }
                        else if (colBomb == matrix.GetLength(1) - 1)
                        {
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                        }
                        else
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                        }
                    }
                    else if (rowBomb == matrix.GetLength(0) - 1)
                    {
                        if (colBomb == 0)
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                        }
                        else if (colBomb == matrix.GetLength(1) - 1)
                        {
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                        }
                        else
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                        }
                    }
                    else
                    {
                        if (colBomb == 0)
                        {
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                        }
                        else if (colBomb == matrix.GetLength(1) - 1)
                        {
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                        }
                        else
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb + 1] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb - 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb - 1] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= bombPower;
                            }
                            if (matrix[rowBomb + 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb + 1] -= bombPower;
                            }
                        }
                    }
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine(matrix[row, matrix.GetLength(1) - 1]);
            }
        }
    }
}
