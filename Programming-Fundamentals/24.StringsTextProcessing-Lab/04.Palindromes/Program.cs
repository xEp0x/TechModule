using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            //Use spaces, commas, dots, question marks and exclamation marks as word delimiters
            char[] delimiters = new char[] { ' ', ',', '.', '?', '!' };

            var text = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palindromes = new List<string>();

            foreach (var word in text)
            {
                if (word.Length == 1)
                {
                    palindromes.Add(word);
                    continue;
                }

                var length = word.Length / 2;
                var firstPart = string.Join("", word.Take(length));
                var secondPart = string.Join("", word.Reverse().Take(length));

                // if (firstPart == secondPart)
                // {
                //     palindromes.Add(word);
                // }

                if (string.Compare(firstPart, secondPart) == 0)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(p => p)));
        }
    }
}
