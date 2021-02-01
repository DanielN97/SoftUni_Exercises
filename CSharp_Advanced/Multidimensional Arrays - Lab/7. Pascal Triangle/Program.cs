using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ulong[][] matrix = new ulong[n][];
            matrix[0] = new ulong[] { 1 };

            if (n > 1)
            {
                matrix[1] = new ulong[] { 1, 1 };
            }

            for (int i = 2; i < n; i++)
            {
                matrix[i] = new ulong[i + 1];
                matrix[i][0] = 1;
                matrix[i][matrix[i].Length - 1] = 1;

                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] = matrix[i - 1][j] + matrix[i - 1][j - 1];
                }
            }

            foreach (ulong[] row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
