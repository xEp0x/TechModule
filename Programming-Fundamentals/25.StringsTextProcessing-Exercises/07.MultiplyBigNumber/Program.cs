using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().TrimStart(new char[] { '0' });
            var str2 = Console.ReadLine().TrimStart(new char[] { '0' });

            if(str1==string.Empty || str2 == string.Empty)
            {
                Console.WriteLine("0");
                return;
            }

            List<int> numArr = new List<int>();

            numArr = str1.ToCharArray().Select(ch => (int)(ch - 48)).ToList();
            var num2 = int.Parse(str2);            

            var mind = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = numArr.Count - 1; i >= 0; i--)
            {
                var multiCurrentDigits = numArr[i] * num2 + mind;
                var digit = multiCurrentDigits % 10;
                mind = multiCurrentDigits / 10;
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
