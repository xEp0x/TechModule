namespace _14.FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = CalcFactorial(number);

            long zeroCount = CountZeroInNumber(factorialNumber);
            Console.WriteLine(zeroCount);
        }

        static long CountZeroInNumber(BigInteger factorialNumber)
        {
            long zeroCount = 0;
            string reversedFactorial = string.Empty;
            char[] numberDigits = factorialNumber.ToString().ToCharArray();

            for (int i = numberDigits.Length - 1; i >= 0; i--)
            {
                reversedFactorial += numberDigits[i];

            }

            for (int i = 0; i <= reversedFactorial.Length - 1; i++)
            {
                if (reversedFactorial[i] == '0')
                {
                    zeroCount++;
                }
                else
                {
                    break;                    
                }
            }

            return zeroCount;
        }

        static BigInteger CalcFactorial(int number)
        {
            BigInteger factorialNumber = 1;

            for (int i = 1; i <= number; i++)
            {
                factorialNumber *= i;
            }

            return factorialNumber;
        }
    }
}
