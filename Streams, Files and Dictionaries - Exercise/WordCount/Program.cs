using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            string text = File.ReadAllText("../../../text.txt");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string lowerText = text.ToLower();

            foreach (string word in words)
            {
                wordsCount.Add(word, 0);
            }

            MatchCollection matches = Regex.Matches(lowerText, @"\b(quick|is|fault)\b");

            foreach (Match match in matches)
            {
                wordsCount[match.Value]++;
            }

            Dictionary<string, int> sortedDictionary = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            List<string> output = sortedDictionary.Select(y => $"{y.Key} - {y.Value}").ToList();

            File.WriteAllLines("../../../actualResults.txt", output);
        }
    }
}
