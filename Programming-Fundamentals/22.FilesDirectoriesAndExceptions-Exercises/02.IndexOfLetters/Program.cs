using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _02.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetSmall = new char[26];
            alphabetSmall = GetLatinAlphabetSmall();

            string[] fileLines = File.ReadAllLines(@"input.txt");

            foreach (var line in fileLines)
            {
                char[] letters = line.ToCharArray();

                foreach (var letter in letters)
                {
                    int index = Array.IndexOf(alphabetSmall, letter);
                    var str = $"{letter} -> {index}";
                    File.AppendAllText(@"output.txt", str + "\n");
                }

                File.AppendAllText(@"output.txt", "---------------------------\n");
            }
        }

        static char[] GetLatinAlphabetSmall()
        {
            char[] alphabetSmall = new char[26];

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetSmall[i - 'a'] = i;
            }
            return alphabetSmall;
        }
    }
}
