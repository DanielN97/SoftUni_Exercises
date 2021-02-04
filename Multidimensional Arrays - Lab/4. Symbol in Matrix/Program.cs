using System;

namespace _4._Symbol_in_Matrix
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

            char character = char.Parse(Console.ReadLine());

            bool isPresent = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == character)
                    {
                        Console.WriteLine($"({row}, {col})");

                        isPresent = true;

                        return;
                    }
                }
            }

            if (!isPresent)
            {
                Console.WriteLine($"{character} does not occur in the matrix");
            }
        }
    }
}
