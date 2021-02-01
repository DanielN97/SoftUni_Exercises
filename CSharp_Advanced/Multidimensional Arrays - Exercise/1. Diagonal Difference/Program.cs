using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                firstDiagonal += matrix[i, i];
            }

            for (int i = 0; i < n; i++)
            {
                secondDiagonal += matrix[i, n - 1 - i];
            }

            if (firstDiagonal >= secondDiagonal)
            {
                Console.WriteLine(firstDiagonal - secondDiagonal);
            }
            else
            {
                Console.WriteLine(secondDiagonal - firstDiagonal);
            }
        }
    }
}
