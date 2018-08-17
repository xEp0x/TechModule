using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetSmall = new char[26];
            alphabetSmall = GetLatinAlphabetSmall();
            char[] inputWord = Console.ReadLine().ToCharArray();

            foreach (char item in inputWord)
            {
                int index = Array.IndexOf(alphabetSmall, item);
                Console.WriteLine($"{item} -> {index}");
            }
        }

        static char[] GetLatinAlphabetSmall()
        {
            char[] alphabetSmall = new char[26];

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetSmall[i-'a'] = i;
            }
            return alphabetSmall;
        }
    }
}
