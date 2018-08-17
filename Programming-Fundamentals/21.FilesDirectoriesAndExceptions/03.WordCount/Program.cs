using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsForCheck = File.ReadAllText(@"c:\temp\words.txt").ToLower().Split();

            char[] delimiters = new char[] { '\n', '\r', ',', ';', ':', '.', '!', '?', '-', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            string[] textWords = File.ReadAllText(@"c:\temp\input3.txt").ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> countedWords = new Dictionary<string, int>();

            foreach (var word in wordsForCheck)
            {
                countedWords.Add(word, 0);
                //countedWords[word] = 0;
            }

            foreach (var word in textWords)
            {
                if (countedWords.ContainsKey(word))
                {
                    countedWords[word]++;
                }
            }

            foreach (var word in countedWords.OrderByDescending(c => c.Value).ThenBy(w => w.Key))
            {
                File.AppendAllText(@"c:\temp\output3.txt", $"{word.Key} - {word.Value}\n");
            }
        }
    }
}
