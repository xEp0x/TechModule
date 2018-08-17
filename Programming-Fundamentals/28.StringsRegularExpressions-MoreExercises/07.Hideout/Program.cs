using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();

            while (true)
            {
                var clue = Console.ReadLine().Split();
                var hideout = clue[0];
                var hideoutCount = int.Parse(clue[1]);
                var pattern = $@"\{hideout}{{{hideoutCount},}}";
                Regex regex = new Regex(pattern);
                Match hideoutMatch = regex.Match(map);

                if (hideoutMatch.Success)
                {
                    var index = hideoutMatch.Index;
                    var count = hideoutMatch.Length;
                    Console.WriteLine($"Hideout found at index {index} and it is with size {count}!");
                    break;
                }
            }
        }
    }
}
