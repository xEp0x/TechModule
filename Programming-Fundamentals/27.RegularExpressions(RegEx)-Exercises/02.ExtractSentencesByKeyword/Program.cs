using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var pattern = @"(\S.+?[.!?])(?=\s+|$)";
            //Console.WriteLine(pattern);
            var word = Console.ReadLine();
            var wordPattern = @"\b" + word + @"\b";
            //Console.WriteLine(wordPattern);
            var inputText = Console.ReadLine();

            Regex wordRegex = new Regex(wordPattern);

            Regex regex = new Regex(pattern);
            MatchCollection sentencesMatches = regex.Matches(inputText);

            foreach (Match sentence in sentencesMatches)
            {
                var sentenceStr = sentence.Value;
                var isWordInSentence = wordRegex.IsMatch(sentenceStr);

                if (isWordInSentence)
                {
                    sentenceStr = sentenceStr.Remove(sentenceStr.Length - 1);
                    Console.WriteLine(sentenceStr);
                }
            }
        }
    }
}
