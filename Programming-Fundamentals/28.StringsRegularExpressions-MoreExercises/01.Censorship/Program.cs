using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Censorship
{
    class Censorship
    {
        static void Main(string[] args)
        {

            var word = Console.ReadLine();
            var sentence = Console.ReadLine();

            var isSentenceContainWord = sentence.Contains(word);
            var result = string.Empty;

            if (isSentenceContainWord)
            {
                result = sentence.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(result == string.Empty ? "" : result);
        }
    }
}
