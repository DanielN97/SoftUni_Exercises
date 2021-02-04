using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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

            int finalCounter = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttack = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = matrix[row, col];
                        int countAttacks = 0;

                        if (currentSymbol == 'K')
                        {
                            countAttacks = Methodchu(matrix, countAttacks, row, col);

                            if (countAttacks > maxAttack)
                            {
                                maxAttack = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    matrix[rowKiller, colKiller] = '0';
                    finalCounter++;
                }
                else
                {
                    Console.WriteLine(finalCounter);
                    break;
                }
            }
        }

        private static int Methodchu(char[,] matrix, int countAttacks, int row, int col)
        {
            if (row >= 1 && col >= 2 && matrix[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (row <= matrix.GetLength(0) - 2 && col >= 2 && matrix[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (row >= 2 && col >= 1 && matrix[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (row >= 2 && col <= matrix.GetLength(1) - 2 && matrix[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (row <= matrix.GetLength(0) - 2 && col <= matrix.GetLength(1) - 3 && matrix[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (row >= 1 && col <= matrix.GetLength(1) - 3 && matrix[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (row <= matrix.GetLength(0) - 3 && col >= 1 && matrix[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (row <= matrix.GetLength(0) - 3 && col <= matrix.GetLength(1) - 2 && matrix[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
        }
    }
}
