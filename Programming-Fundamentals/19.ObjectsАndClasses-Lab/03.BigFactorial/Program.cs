using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            BigInteger numFactorial = 1;

            for (int i = 2; i <= num; i++)
            {
                numFactorial *= i;
            }

            Console.WriteLine(numFactorial);
        }
    }
}
