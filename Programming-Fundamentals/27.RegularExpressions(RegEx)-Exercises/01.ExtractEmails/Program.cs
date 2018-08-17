using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            //var pattern = @"((?<=\s)([A-Za-z0-9]+)(\.|\-|_)?([A-Za-z0-9]+)@[A-Za-z-]+?((\.|\-|_)[A-Za-z]+)+)";
            var pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            var inputLine = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection emailMatches = regex.Matches(inputLine);

            foreach (Match matchEmail in emailMatches)
            {
                Console.WriteLine(matchEmail.Value);
            }
        }
    }
}
