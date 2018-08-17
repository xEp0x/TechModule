using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.CubicsMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<indexBefore>\d+)(?<message>[A-Za-z]+)(?<indexAfter>[^A-Za-z]+)*$";
            List<string> allDecryptedMEssages = new List<string>();
            Regex regex = new Regex(pattern);

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Over!")
                {
                    break;
                }

                Match messageMatch = regex.Match(inputLine);

                if (!messageMatch.Success)
                {
                    continue;
                }

                var messageLength = int.Parse(Console.ReadLine());
                var message = messageMatch.Groups["message"].Value;

                if (message.Length != messageLength)
                {
                    continue;
                }

                var leftIndexes = messageMatch.Groups["indexBefore"].Value
                    .ToCharArray()
                    .Select(ch => int.Parse(ch.ToString()))
                    .ToArray();

                var rightIndexes = messageMatch.Groups["indexAfter"].Value
                    .ToCharArray()
                    .Where(ch => char.IsDigit(ch))
                    .Select(ch => int.Parse(ch.ToString()))
                    .ToArray();

                StringBuilder sb = new StringBuilder();
                DecryptMessage(message, leftIndexes, sb);
                DecryptMessage(message, rightIndexes, sb);

                sb.Insert(0, message + " == ");
                allDecryptedMEssages.Add(sb.ToString());               
            }

            foreach (var message in allDecryptedMEssages)
            {
                Console.WriteLine(message);
            }

        }

        static void DecryptMessage(string message, int[] leftIndexes, StringBuilder sb)
        {
            foreach (var num in leftIndexes)
            {
                if (num < message.Length)
                {
                    sb.Append(message[num]);
                }
                else
                {
                    sb.Append(' ');
                }
            }
        }
    }
}
