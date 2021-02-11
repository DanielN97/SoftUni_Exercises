using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int bestCounter = 0;
            int finalCounter = 0;

            bool notDone = true;

            while (notDone)
            {
                int finalRow = -1;
                int finalCol = -1;

                notDone = false;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int counter = 0;

                        if (matrix[row, col] == 'K')
                        {
                            if (row >= 2 && col >= 1)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row >= 2 && col < matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row >= 1 && col < matrix.GetLength(1) - 2)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 2)
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row < matrix.GetLength(0) - 2 && col >= 1)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row < matrix.GetLength(0) - 2 && col < matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row >= 1 && col >= 2)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (row < matrix.GetLength(0) - 1 && col >= 2)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    counter++;
                                    notDone = true;
                                }
                            }

                            if (counter > bestCounter)
                            {
                                bestCounter = counter;

                                finalRow = row;
                                finalCol = col;
                            }
                        }
                    }
                }

                if (finalRow != -1 && finalCol != -1)
                {
                    matrix[finalRow, finalCol] = '0';

                    bestCounter = 0;

                    finalCounter++;
                }
            }

            Console.WriteLine(finalCounter);
        }
    }
}
