using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            List<int> num1Arr = new List<int>();
            List<int> num2Arr = new List<int>();
            var padLength = Math.Max(str1.Length, str2.Length);
            var pad = '0';
            str1 = str1.PadLeft(padLength, pad);
            str2 = str2.PadLeft(padLength, pad);

            num1Arr = str1.ToCharArray().Select(ch => (int)(ch - 48)).ToList();
            num2Arr = str2.ToCharArray().Select(ch => (int)(ch - 48)).ToList();

            var mind = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = num2Arr.Count - 1; i >= 0; i--)
            {
                var sumCurrentDigits = num2Arr[i] + num1Arr[i] + mind;
                var digit = sumCurrentDigits % 10;
                mind = sumCurrentDigits / 10;
                sb.Append(digit);
            }

            if (mind > 0)
            {
                sb.Append(mind);
            }

            var sbStr = sb.ToString().TrimEnd(new char[] { '0' });
            var num = sbStr.ToCharArray().ToList();
            num.Reverse();
            Console.WriteLine(string.Join("", num));
        }
    }
}
