using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Mines
    {
        static void Main(string[] args)
        {
            var pattern = @"<[A-Za-z]{2}>";
            var inputLine = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputLine);
            Regex regex = new Regex(pattern);

            MatchCollection minebMatches = regex.Matches(inputLine);

            foreach (Match mine in minebMatches)
            {
                var index = mine.Index;
                var firstChar = inputLine[index + 1];
                var secondChar = inputLine[index + 2];
                var minePower = Math.Abs(firstChar - secondChar);
                var destroyIndex = Math.Max(0, index - minePower);
                var destroyBeforeMine = index - destroyIndex;
                var destroyAfterMine = Math.Min(minePower, inputLine.Length -4-index);
                var destroyLength = destroyBeforeMine + 4 + destroyAfterMine;
                var replaceStr = new string('_', destroyLength);

                inputLine = inputLine.Remove(destroyIndex, destroyLength);
                inputLine = inputLine.Insert(destroyIndex, replaceStr);
              
            }
            Console.WriteLine(inputLine);
        }
    }
}
