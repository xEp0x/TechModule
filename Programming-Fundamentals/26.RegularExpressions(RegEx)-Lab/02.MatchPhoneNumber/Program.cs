using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            var pattern = @"\+359( |-)2\1\b[0-9]{3}\b\1\b[0-9]{4}\b";
            var phones = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(m => m.Value.Trim()).ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
