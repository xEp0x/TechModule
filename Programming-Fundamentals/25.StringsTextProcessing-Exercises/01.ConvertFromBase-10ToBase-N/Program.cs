using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var baseN = int.Parse(inputLine[0]);
            var base10Num = BigInteger.Parse(inputLine[1]);

            StringBuilder sb = new StringBuilder();

            while (base10Num > 0)
            {
                var remainder = base10Num % baseN;
                sb.Append(remainder);
                base10Num /= baseN;
            }

            var outputNumDigits = sb.ToString().ToCharArray().ToList();
            outputNumDigits.Reverse();

            Console.WriteLine(string.Join("", outputNumDigits));
        }
    }
}
