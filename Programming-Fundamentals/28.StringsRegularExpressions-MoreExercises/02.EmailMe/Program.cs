using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split('@').ToList();
            var firstPart = inputLine[0].ToList();
            var secondPart = inputLine[1].ToList();

            var firstSum = firstPart.Select(c => (int)c).Sum();
            var secondSum = secondPart.Select(c => (int)c).Sum();

            Console.WriteLine(secondSum <= firstSum ? "Call her!" : "She is not the one.");
        }
    }
}
