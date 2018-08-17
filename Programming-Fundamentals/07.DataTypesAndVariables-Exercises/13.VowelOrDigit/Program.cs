using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int asciiNumber = (int)symbol;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            bool isSymbolVowel = false;
            bool isSymbolDigit = char.IsDigit(symbol);

            foreach (char ch in vowels)
            {
                if (ch == symbol)
                {
                    isSymbolVowel = true;
                }
            }

            if (isSymbolVowel)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                if (isSymbolDigit)
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }

        }
    }
}
