using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(0x)?[0-9A-F]+\b";
            var inputLine = Console.ReadLine();

            MatchCollection HexMatches = Regex.Matches(inputLine, pattern);
            var matchedHexNums = HexMatches.Cast<Match>().Select(m => m.Value).ToList();

            Console.WriteLine(string.Join(" ", matchedHexNums));
        }
    }
}
