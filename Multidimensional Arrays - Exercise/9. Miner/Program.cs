using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            string[] moveCommands = Console.ReadLine().Split();

            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];

            int currentRow = 0;
            int currentCol = 0;

            int maxCoal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        maxCoal++;
                    }
                }
            }

            int collectedCoal = 0;

            for (int i = 0; i < moveCommands.Length; i++)
            {
                string currentCommand = moveCommands[i];

                if (currentCommand == "left" && currentCol > 0)
                {
                    currentCol--;
                }
                else if (currentCommand == "right" && currentCol < matrix.GetLength(1) - 1)
                {
                    currentCol++;
                }
                else if (currentCommand == "up" && currentRow > 0)
                {
                    currentRow--;
                }
                else if (currentCommand == "down" && currentRow < matrix.GetLength(0) - 1)
                {
                    currentRow++;
                }

                if (matrix[currentRow, currentCol] == 'c')
                {
                    collectedCoal++;
                    matrix[currentRow, currentCol] = '*';

                    if (collectedCoal == maxCoal)
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

            Console.WriteLine($"{maxCoal - collectedCoal} coals left. ({currentRow}, {currentCol})");
        }
    }
}
