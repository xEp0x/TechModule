using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
            var patterns = new string[] { @"@{6,10}", @"#{6,10}", @"\^{6,10}", @"\${6,10}" };

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstHalf = ticket.Substring(0, 10);
                var secondHalf = ticket.Substring(10);
                var isMatch = false;
                var winningSymbol = ' ';
                int countWinningSymbolFirstHalf = 0;
                int countWinningSymbolSecondtHalf = 0;

                foreach (var pattern in patterns)
                {
                    Match left = Regex.Match(firstHalf, pattern);
                    Match right = Regex.Match(secondHalf, pattern);

                    if (!left.Success || !right.Success)
                    {
                        continue;
                    }

                    winningSymbol = left.ToString()[0];
                    countWinningSymbolFirstHalf = left.Length;
                    countWinningSymbolSecondtHalf = right.Length;
                    isMatch = true;
                    break;
                }

                if (!isMatch)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                var winningCount = Math.Min(countWinningSymbolFirstHalf, countWinningSymbolSecondtHalf);

                Console.WriteLine((countWinningSymbolFirstHalf == 10 && countWinningSymbolSecondtHalf == 10)
                    ? $"ticket \"{ticket}\" - {winningCount}{winningSymbol} Jackpot!"
                    : $"ticket \"{ticket}\" - {winningCount}{winningSymbol}");
            }
        }
    }
}
