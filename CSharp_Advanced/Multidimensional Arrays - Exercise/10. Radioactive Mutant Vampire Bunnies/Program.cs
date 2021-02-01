using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
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

            char[] commands = Console.ReadLine().ToCharArray();

            bool escaped = false;
            bool alive = true;

            for (int i = 0; i < commands.Length; i++)
            {
                if (!escaped && alive)
                {
                    if (commands[i] == 'L')
                    {
                        if (currentCol != 0)
                        {
                            if (matrix[currentRow, currentCol - 1] != 'B')
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentCol--;
                                matrix[currentRow, currentCol] = 'P';
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentCol--;
                                alive = false;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = '.';
                            escaped = true;
                        }
                    }
                    else if (commands[i] == 'R')
                    {
                        if (currentCol != matrix.GetLength(1) - 1)
                        {
                            if (matrix[currentRow, currentCol + 1] != 'B')
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentCol++;
                                matrix[currentRow, currentCol] = 'P';
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentCol++;
                                alive = false;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = '.';
                            escaped = true;
                        }
                    }
                    else if (commands[i] == 'U')
                    {
                        if (currentRow != 0)
                        {
                            if (matrix[currentRow - 1, currentCol] != 'B')
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentRow--;
                                matrix[currentRow, currentCol] = 'P';
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentRow--;
                                alive = false;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = '.';
                            escaped = true;
                        }
                    }
                    else if (commands[i] == 'D')
                    {
                        if (currentRow != matrix.GetLength(0) - 1)
                        {
                            if (matrix[currentRow + 1, currentCol] != 'B')
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentRow++;
                                matrix[currentRow, currentCol] = 'P';
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = '.';
                                currentRow++;
                                alive = false;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = '.';
                            escaped = true;
                        }
                    }

                    Queue<int> queue = new Queue<int>();

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row, col] == 'B')
                            {
                                queue.Enqueue(row);
                                queue.Enqueue(col);
                            }
                        }
                    }

                    while (queue.Count > 0)
                    {
                        int row = queue.Dequeue();
                        int col = queue.Dequeue();

                        if (row == 0)
                        {
                            if (col == 0)
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                            }
                            else if (col == matrix.GetLength(1) - 1)
                            {
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                            }
                            else
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                            }
                        }
                        else if (row == matrix.GetLength(0) - 1)
                        {
                            if (col == 0)
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                            }
                            else if (col == matrix.GetLength(1) - 1)
                            {
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                            }
                            else
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                            }
                        }
                        else
                        {
                            if (col == 0)
                            {
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                            }
                            else if (col == matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                            }
                            else
                            {
                                if (matrix[row, col + 1] == '.')
                                {
                                    matrix[row, col + 1] = 'B';
                                }
                                if (matrix[row - 1, col] == '.')
                                {
                                    matrix[row - 1, col] = 'B';
                                }
                                if (matrix[row, col - 1] == '.')
                                {
                                    matrix[row, col - 1] = 'B';
                                }
                                if (matrix[row + 1, col] == '.')
                                {
                                    matrix[row + 1, col] = 'B';
                                }
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                bool flag = false;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'P')
                        {
                            alive = true;
                            flag = true;
                            break;
                        }
                        else
                        {
                            alive = false;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            if (escaped)
            {
                Console.WriteLine($"won: {currentRow} {currentCol}");
            }
            else if (!alive)
            {
                Console.WriteLine($"dead: {currentRow} {currentCol}");
            }
        }
    }
}
