using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            //var delimiters = new char[] { ' ', '\\', '/', '(', ')' };
            var pattern = @"\b[A-Za-z]\w{2,24}\b";
            //var inputLine = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var inputLine = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection usernameMatches = regex.Matches(inputLine);
            List<string> usernames = new List<string>();

            foreach (Match usernameMatch in usernameMatches)
            {
                var username = usernameMatch.Value;
                usernames.Add(username);
            }

            var maxSum = 0;
            var firstUser = string.Empty;
            var secondUser = string.Empty;

            for (int i = 0; i < usernames.Count - 1; i++)
            {
                var currentLen = usernames[i].Length;
                var nextLen = usernames[i + 1].Length;
                var sum = currentLen + nextLen;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstUser = usernames[i];
                    secondUser = usernames[i + 1];
                }
            }

            if (usernames.Count == 1)
            {
                firstUser = usernames[0];
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
