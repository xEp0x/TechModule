using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternStartKey = @"[A-Za-z]+[|<\\]";
            var patternEndKey = @"[|<\\][A-Za-z]+";

            var inputLineKeys = Console.ReadLine();

            Regex regexStartKey = new Regex(patternStartKey);
            MatchCollection startKeysMatches = regexStartKey.Matches(inputLineKeys);

            Regex regexEndKey = new Regex(patternEndKey);
            MatchCollection endKeysMatches = regexEndKey.Matches(inputLineKeys);

            var startKeyMatch = startKeysMatches[0];
            var startKey = startKeyMatch.Value.Remove(startKeyMatch.Length - 1);
            var endKeyMatch = endKeysMatches[endKeysMatches.Count - 1];
            var endKey = endKeyMatch.Value.Remove(0, 1);

            var inputText = Console.ReadLine();
            var tempText = inputText;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                var indexStartKey = tempText.IndexOf(startKey);
                var indexEndKey = tempText.IndexOf(endKey);                

                if (indexStartKey == -1 || indexEndKey == -1)
                {
                    break;
                }

                if (indexStartKey == indexEndKey)
                {
                    break;
                   //var tempStr = tempText.Substring(indexStartKey + startKey.Length);
                   //indexEndKey = indexStartKey + startKey.Length + tempStr.IndexOf(endKey);
                }

                var startIndex = indexStartKey + startKey.Length;
                var length = indexEndKey - startIndex;
                var currentText = tempText.Substring(startIndex, length);
                sb.Append(currentText);
                tempText = tempText.Substring(startIndex + length + endKey.Length);

            }

            var outputMessage = sb.ToString();

            if (outputMessage == string.Empty)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
