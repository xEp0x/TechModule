using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();
            var baseN = int.Parse(inputLine[0]);
            var baseNNum = inputLine[1].ToCharArray();
            BigInteger base10Num = new BigInteger();
            BigInteger power = 1;

            for (int i = baseNNum.Length - 1; i >= 0; i--)
            {
                base10Num += power * (baseNNum[i] - 48);
                power *= baseN;
            }

            Console.WriteLine(base10Num);
        }
    }
}
