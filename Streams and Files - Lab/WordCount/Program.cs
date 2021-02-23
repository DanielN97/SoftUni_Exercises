using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsOccurrences = new Dictionary<string, int>();

            using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            {
                string[] wordsToFind = wordsReader.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in wordsToFind)
                {
                    wordsOccurrences.Add(word, 0);
                }

                using (StreamReader textReader = new StreamReader("../../../text.txt"))
                {
                    List<char> chars = new List<char>();

                    for (int i = 32; i < 39; i++)
                    {
                        chars.Add((char)i);
                    }
                    for (int i = 40; i < 65; i++)
                    {
                        chars.Add((char)i);
                    }
                    for (int i = 91; i < 97; i++)
                    {
                        chars.Add((char)i);
                    }
                    for (int i = 123; i < 127; i++)
                    {
                        chars.Add((char)i);
                    }

                    List<string> wordsInText = textReader.ReadToEnd().Split(chars.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                    for (int i = 0; i < wordsInText.Count; i++)
                    {
                        if (wordsInText[i].Contains("…"))
                        {
                            string badWord = wordsInText[i];

                            wordsInText.RemoveAt(i);

                            string[] newWords = badWord.Split("…");

                            wordsInText.Insert(i, badWord.Substring(0, newWords[0].Length));
                            wordsInText.Insert(i + 1, badWord.Substring(newWords[0].Length + 1, newWords[1].Length));

                            break;
                        }
                    }

                    for (int i = 0; i < wordsInText.Count; i++)
                    {
                        wordsInText[i] = wordsInText[i].ToLower(); 
                    }

                    foreach (string wordToFind in wordsToFind)
                    {
                        foreach (string wordInText in wordsInText)
                        {
                            if (wordToFind == wordInText)
                            {
                                wordsOccurrences[wordToFind]++;
                            }
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                foreach (var item in wordsOccurrences.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
