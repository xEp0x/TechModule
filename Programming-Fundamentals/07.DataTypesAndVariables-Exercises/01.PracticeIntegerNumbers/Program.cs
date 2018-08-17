using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PracticeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numSbyte = -100;
            byte numByte = 128;
            short numShort = -3540;
            ushort numUshort = 64876;
            uint numUint = 2147483648;
            int numInt = -1141583228;
            long numLong = -1223372036854775808;

            Console.WriteLine(numSbyte);
            Console.WriteLine(numByte);
            Console.WriteLine(numShort);
            Console.WriteLine(numUshort);
            Console.WriteLine(numUint);
            Console.WriteLine(numInt);
            Console.WriteLine(numLong);
        }
    }
}
