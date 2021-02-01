using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            float[][] matrix = new float[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new float[rowData.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Add" && int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= matrix.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix[int.Parse(command[1])].Length)
                {
                    int rowPosition = int.Parse(command[1]);
                    int colPosition = int.Parse(command[2]);
                    int number = int.Parse(command[3]);

                    matrix[rowPosition][colPosition] += number;
                }
                else if (command[0] == "Subtract" && int.Parse(command[1]) >= 0 && int.Parse(command[1]) <= matrix.Length && int.Parse(command[2]) >= 0 && int.Parse(command[2]) < matrix[int.Parse(command[1])].Length)
                {
                    int rowPosition = int.Parse(command[1]);
                    int colPosition = int.Parse(command[2]);
                    int number = int.Parse(command[3]);

                    matrix[rowPosition][colPosition] -= number;
                }

                command = Console.ReadLine().Split();
            }

            foreach (float[] row in matrix)
            {
                Console.WriteLine(String.Join(' ', row));
            }
        }
    }
}
