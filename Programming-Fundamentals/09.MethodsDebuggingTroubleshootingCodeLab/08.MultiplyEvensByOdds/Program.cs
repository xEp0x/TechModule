namespace _08.MultiplyEvensByOdds
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long result = MultiplyEvenOddsDigits(number);
            Console.WriteLine(result);
        }

        static long MultiplyEvenOddsDigits(int number)
        {
            long result = SumEvenDigits(number) * SumOddDigits(number);

            return result;
        }

        static int SumDigits(int start, int number)
        {
            string numberToString = Convert.ToString(number);
            char[] digits = numberToString.ToCharArray();
            int sum = 0;

            if (digits[0] == '-')
            {
                start++;
            }

            for (int i = start; i < digits.Length; i += 2)
            {
                sum += (digits[i] - 48);
            }

            return sum;
        }

        static int SumOddDigits(int number)
        {
            int sumOdd = SumDigits(0, number);

            return sumOdd;
        }        

        static int SumEvenDigits(int number)
        {
            int sumEven = SumDigits(1, number);

            return sumEven;
        }
    }
}
