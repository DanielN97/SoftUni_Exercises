using System;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> isUpper = x => char.IsUpper(x[0]);

            foreach (string word in inputWords)
            {
                if (isUpper(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
