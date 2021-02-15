using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            foreach (char character in text)
            {
                if (!characters.ContainsKey(character))
                {
                    characters.Add(character, 0);
                }

                characters[character]++;
            }

            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
