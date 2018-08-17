using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            List<string> text = Console.ReadLine().ToLower().Split().ToList();

            foreach (var word in text)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }

            List<string> countedWords = words.Where(pair => pair.Value % 2 == 1).Select(pair => pair.Key).ToList();

            Console.WriteLine(string.Join(", ", countedWords));
        }
    }
}
