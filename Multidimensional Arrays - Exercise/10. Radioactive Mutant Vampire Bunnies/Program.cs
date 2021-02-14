using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n = sizeOfMatrix[0];
            int m = sizeOfMatrix[1];

            char[,] matrix = new char[sizeOfMatrix[0], sizeOfMatrix[1]];

            int currentRow = -1;
            int currentCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            string commands = Console.ReadLine();

            List<string> rabbitsCoordinates = new List<string>();

            bool isWon = false;
            bool isDead = false;

            foreach (char command in commands)
            {
                List<int[]> bunniesCoordinates = GetBunniesCoordinates(matrix);

                int newRow = currentRow;
                int newCol = currentCol;

                if (command == 'L')
                {
                    newCol--;
                }
                else if (command == 'R')
                {
                    newCol++;
                }
                else if (command == 'U')
                {
                    newRow--;
                }
                else if (command == 'D')
                {
                    newRow++;
                }

                if (!IsValidPossition(newRow, newCol, matrix.GetLength(0), matrix.GetLength(1)))
                {
                    isWon = true;
                    matrix[currentRow, currentCol] = '.';
                    SpreadBunnies(bunniesCoordinates, matrix);
                }
                else if (matrix[newRow, newCol] == '.')
                {
                    matrix[currentRow, currentCol] = '.';
                    matrix[newRow, newCol] = 'P';

                    currentRow = newRow;
                    currentCol = newCol;

                    SpreadBunnies(bunniesCoordinates, matrix);

                    if (matrix[currentRow, currentCol] == 'B')
                    {
                        isDead = true;
                    }
                }
                else if (matrix[newRow, newCol] == 'B')
                {
                    isDead = true;
                    matrix[currentRow, currentCol] = '.';

                    currentRow = newRow;
                    currentCol = newCol;

                    SpreadBunnies(bunniesCoordinates, matrix);
                }

                if (isDead || isWon)
                {
                    break;
                }
            }

            string message = String.Empty;

            if (isWon)
            {
                message = "won:";
            }
            else if (isDead)
            {
                message = "dead:";
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{message} {currentRow} {currentCol}");
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] matrix)
        {
            foreach (int[] bunnyCoordinates in bunniesCoordinates)
            {
                int bunnyRow = bunnyCoordinates[0];
                int bunnyCol = bunnyCoordinates[1];

                SpreadBunny(bunnyRow - 1, bunnyCol, matrix);
                SpreadBunny(bunnyRow + 1, bunnyCol, matrix);
                SpreadBunny(bunnyRow, bunnyCol - 1, matrix);
                SpreadBunny(bunnyRow, bunnyCol + 1, matrix);
            }
        }

        private static void SpreadBunny(int bunnyRow, int bunnyCol, char[,] matrix)
        {
            if (IsValidPossition(bunnyRow, bunnyCol, matrix.GetLength(0), matrix.GetLength(1)))
            {
                matrix[bunnyRow, bunnyCol] = 'B';
            }
        }

        private static List<int[]> GetBunniesCoordinates(char[,] matrix)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }

            return bunniesCoordinates;
        }

        private static bool IsValidPossition(int newRow, int newCol, int n, int m)
        {
            return newRow >= 0 && newRow < n && newCol >= 0 && newCol < m;
        }
    }
}
