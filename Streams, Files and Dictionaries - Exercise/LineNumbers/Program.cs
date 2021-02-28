using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines("../../../text.txt");
            string[] outputLines = new string[inputLines.Length];

            int counter = 1;

            foreach (string line in inputLines)
            {
                int lettersCounter = 0;
                int punctuationsCounter = 0;

                foreach (char character in line)
                {
                    if (char.IsLetter(character))
                    {
                        lettersCounter++;
                    }
                    else if (char.IsPunctuation(character))
                    {
                        punctuationsCounter++;
                    }
                }

                outputLines[counter - 1] = $"Line {counter}: {inputLines[counter - 1]} ({lettersCounter})({punctuationsCounter})";

                counter++;
            }

            File.WriteAllLines("../../../output.txt", outputLines);
        }
    }
}
