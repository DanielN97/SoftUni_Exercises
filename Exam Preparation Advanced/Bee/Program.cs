using System;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'B')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            bool isLost = false;

            int pollinatedFlowers = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (command == "up")
                {
                    matrix[currentRow, currentCol] = '.';

                    currentRow--;

                    if (!IsInside(matrix, currentRow, currentCol))
                    {
                        isLost = true;
                        break;
                    }

                    if (matrix[currentRow, currentCol] == 'f')
                    {
                        pollinatedFlowers++;
                    }
                    else if (matrix[currentRow, currentCol] == 'O')
                    {
                        matrix[currentRow, currentCol] = '.';

                        currentRow--;

                        if (matrix[currentRow, currentCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                    }

                    matrix[currentRow, currentCol] = 'B';
                }
                else if (command == "down")
                {
                    matrix[currentRow, currentCol] = '.';

                    currentRow++;

                    if (!IsInside(matrix, currentRow, currentCol))
                    {
                        isLost = true;
                        break;
                    }

                    if (matrix[currentRow, currentCol] == 'f')
                    {
                        pollinatedFlowers++;
                    }
                    else if (matrix[currentRow, currentCol] == 'O')
                    {
                        matrix[currentRow, currentCol] = '.';

                        currentRow++;

                        if (matrix[currentRow, currentCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                    }

                    matrix[currentRow, currentCol] = 'B';
                }
                else if (command == "left")
                {
                    matrix[currentRow, currentCol] = '.';

                    currentCol--;

                    if (!IsInside(matrix, currentRow, currentCol))
                    {
                        isLost = true;
                        break;
                    }

                    if (matrix[currentRow, currentCol] == 'f')
                    {
                        pollinatedFlowers++;
                    }
                    else if (matrix[currentRow, currentCol] == 'O')
                    {
                        matrix[currentRow, currentCol] = '.';

                        currentCol--;

                        if (matrix[currentRow, currentCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                    }

                    matrix[currentRow, currentCol] = 'B';
                }
                else if (command == "right")
                {
                    matrix[currentRow, currentCol] = '.';

                    currentCol++;

                    if (!IsInside(matrix, currentRow, currentCol))
                    {
                        isLost = true;
                        break;
                    }

                    if (matrix[currentRow, currentCol] == 'f')
                    {
                        pollinatedFlowers++;
                    }
                    else if (matrix[currentRow, currentCol] == 'O')
                    {
                        matrix[currentRow, currentCol] = '.';

                        currentCol++;

                        if (matrix[currentRow, currentCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                    }

                    matrix[currentRow, currentCol] = 'B';
                }
            }

            if (isLost)
            {
                Console.WriteLine("The bee got lost!");
            }

            if (pollinatedFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        static bool IsInside(char[,] matrix, int currentRow, int currentCol)
        {
            if (currentRow < 0 || currentCol < 0 || currentRow >= matrix.GetLength(0) || currentCol >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
