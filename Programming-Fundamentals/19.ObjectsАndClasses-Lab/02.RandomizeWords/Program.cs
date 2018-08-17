using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').ToList();
            Random rnd = new Random();

            var randomResult = new List<string>();

            for (int i = 0; i < inputLine.Count; i++)
            {
                var currentWord = inputLine[i];
                var index = rnd.Next(inputLine.Count);
                var randomWord = inputLine[index];

                randomResult.Add(randomWord);
                inputLine[index] = currentWord;
                inputLine[i] = randomWord;                
            }

            foreach (var word in inputLine)
            {
                Console.WriteLine(word);
            }

        }
    }
}
