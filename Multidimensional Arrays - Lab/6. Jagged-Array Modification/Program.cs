using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[row] = new int[rowData.Length];

                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    jaggedMatrix[row][col] = rowData[col];
                }
            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                if (input[0] == "Add")
                {
                    if (int.Parse(input[1]) <= jaggedMatrix.Length - 1&& int.Parse(input[1]) >= 0 && int.Parse(input[2]) >= 0)
                    {
                        if (int.Parse(input[2]) <= jaggedMatrix[int.Parse(input[1])].Length - 1)
                        {
                        jaggedMatrix[int.Parse(input[1])][int.Parse(input[2])] += int.Parse(input[3]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (input[0] == "Subtract")
                {
                    if (int.Parse(input[1]) <= jaggedMatrix.Length - 1 && int.Parse(input[1]) >= 0 && int.Parse(input[2]) >= 0)
                    {
                        if (int.Parse(input[2]) <= jaggedMatrix[int.Parse(input[1])].Length - 1)
                        {
                        jaggedMatrix[int.Parse(input[1])][int.Parse(input[2])] -= int.Parse(input[3]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine().Split();
            }

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    Console.Write(jaggedMatrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
