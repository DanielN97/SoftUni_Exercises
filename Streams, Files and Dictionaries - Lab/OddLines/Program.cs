using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\danie\Desktop\New folder\Resources\01. Odd Lines\Input.txt"))
            {
                int row = 0;
                string currentRow = reader.ReadLine();

                while (currentRow != null)
                {
                    if (row % 2 == 1)
                    {
                        Console.WriteLine(currentRow);
                    }

                    currentRow = reader.ReadLine();
                    row++;
                }
            }
        }
    }
}
