using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[][] matrix = new long[numberOfRows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[row + 1];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col == 0 || col == row)
                    {
                        matrix[row][col] = 1;
                    }
                    else
                    {
                        matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(String.Join(" ", matrix[row]));
            }
        }
    }
}
