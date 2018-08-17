using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            var bojoPattern = @"([A-Za-z]+)\-([A-Za-z]+)";
            var didiPattern = @"([^A-Za-z\-]+)";

            Regex bojoRegex = new Regex(bojoPattern);
            Regex didiRegex = new Regex(didiPattern);

            var inputLine = Console.ReadLine();

            while (true)
            {
                Match didiMatch = didiRegex.Match(inputLine);

                if (!didiMatch.Success)
                {
                    break;
                }

                var didimon = didiMatch.Value;
                var didiIndex = inputLine.IndexOf(didimon);
                Console.WriteLine(didimon);
                inputLine = inputLine.Remove(0, didiIndex + didimon.Length);

                Match bojoMatch = bojoRegex.Match(inputLine);

                if (!bojoMatch.Success)
                {
                    break;
                }

                var bojomon = bojoMatch.Value;
                var bojoIndex = inputLine.IndexOf(bojomon);
                Console.WriteLine(bojomon);
                inputLine = inputLine.Remove(0, bojoIndex + bojomon.Length);
            }
        }
    }
}
