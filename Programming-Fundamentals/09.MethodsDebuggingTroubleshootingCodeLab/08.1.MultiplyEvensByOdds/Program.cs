namespace _08._1.MultiplyEvensByOdds
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            long result = MultiplyEvenOddsDigits(number);
            Console.WriteLine(result);
        }

        static long MultiplyEvenOddsDigits(int number)
        {
            long result = SumEvenDigits(number) * SumOddDigits(number);

            return result;
        }

        static int SumOddDigits(int number)
        {
            int sumOdd = 0;            

            while (number>0)
            {
                int lastDigit = 0;
                lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdd += lastDigit;
                }
                number /= 10;
            }

            return sumOdd;
        }

        static int SumEvenDigits(int number)
        {
            int sumEven = 0;

            while (number > 0)
            {
                int lastDigit = 0;
                lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                number /= 10;
            }

            return sumEven;
        }
    }
}
