using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int counter = 1;

                while (!reader.EndOfStream)
                {
                    string currentLine = reader.ReadLine();
                    counter++;

                    if (counter % 2 == 0)
                    {
                        Regex regex = new Regex(@"[-,.!?]");

                        string replacedLine =  regex.Replace(currentLine, "@");

                        string[] words = replacedLine.Split();
                        string[] reversedLine = words.Reverse().ToArray(); ;

                        Console.WriteLine(String.Join(" ", reversedLine));
                    }
                }
            }
        }
    }
}
