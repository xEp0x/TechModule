using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            try
            {
                long number = long.Parse(inputNumber);

                bool isNumberLong = long.MinValue <= number && number <= long.MaxValue;
                bool isNumberUint = uint.MinValue <= number && number <= uint.MaxValue;
                bool isNumberInt = int.MinValue <= number && number <= int.MaxValue;
                bool isNumberUshort = ushort.MinValue <= number && number <= ushort.MaxValue;
                bool isNumberShort = short.MinValue <= number && number <= short.MaxValue;
                bool isNumberByte = byte.MinValue <= number && number <= byte.MaxValue;
                bool isNumberSbyte = sbyte.MinValue <= number && number <= sbyte.MaxValue;

                Console.WriteLine($"{number} can fit in:");

                if (isNumberSbyte)
                {                    
                    Console.WriteLine("* sbyte");
                }

                if (isNumberByte)
                {
                    Console.WriteLine("* byte");
                }

                if (isNumberShort)
                {
                    Console.WriteLine("* short");
                }

                if (isNumberUshort)
                {
                    Console.WriteLine("* ushort");
                }

                if (isNumberInt)
                {
                    Console.WriteLine("* int");
                }

                if (isNumberUint)
                {
                    Console.WriteLine("* uint");
                }

                if (isNumberLong)
                {
                    Console.WriteLine("* long");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine($"{inputNumber} can't fit in any type");
            }
        }
    }
}
