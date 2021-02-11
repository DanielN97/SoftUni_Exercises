using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            string[] commands = Console.ReadLine().Split();

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int currentRow = -1;
            int currentCol = -1;

            int coalCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }
                }
            }

            int coalCollected = 0;

            foreach (string command in commands)
            {
                if (command == "left" && currentCol > 0)
                {
                    currentCol--;

                    if (matrix[currentRow, currentCol] == 'c')
                    {
                        matrix[currentRow, currentCol] = '*';

                        coalCollected++;
                        if (coalCollected == coalCount)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

                            return;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                        return;
                    }
                }
                else if (command == "right" && currentCol < matrix.GetLength(1) - 1)
                {
                    currentCol++;

                    if (matrix[currentRow, currentCol] == 'c')
                    {
                        matrix[currentRow, currentCol] = '*';

                        coalCollected++;
                        if (coalCollected == coalCount)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

                            return;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                        return;
                    }
                }
                else if (command == "up" && currentRow > 0)
                {
                    currentRow--;

                    if (matrix[currentRow, currentCol] == 'c')
                    {
                        matrix[currentRow, currentCol] = '*';

                        coalCollected++;
                        if (coalCollected == coalCount)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

                            return;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                        return;
                    }
                }
                else if (command == "down" && currentRow < matrix.GetLength(0) - 1)
                {
                    currentRow++;

                    if (matrix[currentRow, currentCol] == 'c')
                    {
                        matrix[currentRow, currentCol] = '*';

                        coalCollected++;
                        if (coalCollected == coalCount)
                        {
                            Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");

                            return;
                        }
                    }
                    else if (matrix[currentRow, currentCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({currentRow}, {currentCol})");

                        return;
                    }
                }
            }

            Console.WriteLine($"{coalCount - coalCollected} coals left. ({currentRow}, {currentCol})");
        }
    }
}