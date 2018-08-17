using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _8.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var sequenceses = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //var sequenceses = Console.ReadLine().Split(new char[] {' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var sum = 0.0;

            foreach (var sequence in sequenceses)
            {
                var currentResult = 0.0;
                var firstChar = sequence.First();
                var lastChar = sequence.Last();
                var numStr = sequence.Remove(sequence.Length - 1, 1);
                numStr = numStr.Remove(0, 1);
                var num = int.Parse(numStr);
                //var num = int.Parse(string.Join("", sequence.Skip(1).Take(sequence.Length - 2).ToList()));

                var isFirstCharLower = char.IsLower(firstChar);

                if (isFirstCharLower)
                {
                    var charPos = (int)firstChar - 96;
                    currentResult = 1.0 * num * charPos;
                }
                else
                {
                    var charPos = (int)firstChar - 64;
                    currentResult = 1.0 * num / charPos;
                }

                var isLastCharLower = char.IsLower(lastChar);

                if (isLastCharLower)

                {
                    var charPos = (int)lastChar - 96;
                    currentResult = currentResult + charPos;
                }
                else
                {
                    var charPos = (int)lastChar - 64;
                    currentResult = currentResult - charPos;
                }

                sum += currentResult;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
