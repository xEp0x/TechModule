using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var str1 = string.Empty;
            var str2 = string.Empty;

            if (inputLine[0].Length > inputLine[1].Length)
            {
                str1 = inputLine[0];
                str2 = inputLine[1];
            }
            else
            {
                str1 = inputLine[1];
                str2 = inputLine[0];
            }

            var sum = CalcSumCharMultiply(str1, str2);
            Console.WriteLine(sum);
        }

        static int CalcSumCharMultiply(string str1, string str2)
        {
            var sum = 0;

            for (int i = 0; i < str2.Length; i++)
            {
                sum += str1[i] * str2[i];
            }

            var restSum = str1.Skip(str2.Length).Select(ch => ch).Sum(ch => (int)ch);
            sum += restSum;

            return sum;
        }
    }
}
