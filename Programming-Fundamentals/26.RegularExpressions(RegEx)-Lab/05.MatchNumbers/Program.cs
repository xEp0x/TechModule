using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var inputLine = Console.ReadLine();

            MatchCollection numMatches = Regex.Matches(inputLine, pattern);
            List<string> nums = new List<string>();

            foreach (Match num in numMatches)
            {
                var number = num.Value;
                nums.Add(number);
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
