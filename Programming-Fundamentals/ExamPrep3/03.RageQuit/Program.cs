using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            //var pattern = @"([^0-9]+\d+)";
            var pattern = @"(?<text>\D+)(?<count>\d+)";
            var inputLine = Console.ReadLine().ToUpper();
            Regex regex = new Regex(pattern);
            
            MatchCollection inputLineMatches = regex.Matches(inputLine);
            StringBuilder sb = new StringBuilder();

            foreach (Match strMatch in inputLineMatches)
            {
                var text = strMatch.Groups["text"].Value;
                var count = int.Parse(strMatch.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    sb.Append(text);
                }
            }

            var outputStr = sb.ToString();
            var uniqueSymbolCount = outputStr.Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbolCount}");
            Console.WriteLine(outputStr);
        }
    }
}
