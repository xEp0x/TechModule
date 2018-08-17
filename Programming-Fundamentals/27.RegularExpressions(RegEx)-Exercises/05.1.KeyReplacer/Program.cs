using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05._1.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var patternKey = @"(?<startKey>[A-Za-z]+)[<|\|\\](?<text>.*?)[<|\||\\](?<endKey>[A-Za-z]+)";
            var lineKeys = Console.ReadLine();

            var startKey = Regex.Match(lineKeys, patternKey).Groups["startKey"].Value;
            var endKey = Regex.Match(lineKeys, patternKey).Groups["endKey"].Value;
            // Console.WriteLine(startKey);
            // Console.WriteLine(endKey);

            var patternText = $@"{startKey}(?<text>.*?){endKey}";
            var inputText = Console.ReadLine();

            MatchCollection textMatches = Regex.Matches(inputText, patternText);
            StringBuilder sb = new StringBuilder();

            foreach (Match text in textMatches)
            {
                var currentText = text.Groups["text"].Value;
                sb.Append(currentText);
            }

            if (sb.Length == 0)
            {
                Console.WriteLine("Empty result");
                return;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
