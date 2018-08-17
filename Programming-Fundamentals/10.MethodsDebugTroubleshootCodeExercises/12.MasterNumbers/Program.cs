namespace _12.MasterNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int rangeNumber = int.Parse(Console.ReadLine());
            
            PrintAllMasterNumbersInRange(rangeNumber);
        }

        static void PrintAllMasterNumbersInRange(int rangeNumber)
        {            
            for (int i = 0; i < rangeNumber; i++)
            {
                bool isMasterNumber = CheckIsMasterNumber(i);
                if (isMasterNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckIsMasterNumber(int number)
        {
            bool IsPalindrome = CheckIsNumberPalindrome(number);
            bool IsSumDigitsDivide = CheckIsSumDigitsDivide(number, IsPalindrome);
            bool IsContainEvenDigit = CheckIsContainEvenDigit(number, IsSumDigitsDivide);

            bool isMasterNumber = IsContainEvenDigit;

            return isMasterNumber;
        }

        static bool CheckIsContainEvenDigit(int number, bool IsSumDigitsDivide)
        {
            if (IsSumDigitsDivide)
            {
                while (number > 0)
                {
                    int tempNumber = number % 10;
                    if (tempNumber % 2 == 0)
                    {
                        return true;
                    }
                    number = number / 10;
                }
            }

            return false;
        }

        static bool CheckIsSumDigitsDivide(int number, bool IsPalindrome)
        {
            if (IsPalindrome)
            {
                int sum = 0;
                while (number > 0)
                {
                    int tempNumber = number % 10;
                     sum += tempNumber;
                    number = number / 10;
                }

                if (sum % 7 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool CheckIsNumberPalindrome(int number)
        {
            int numberForCheck = Math.Abs(number);
            int count = 0;
            int reversedNumber = 0;

            while (numberForCheck > 0)
            {
                int tempNumber = numberForCheck % 10;
                reversedNumber = tempNumber + reversedNumber * 10;
                numberForCheck = numberForCheck / 10;
                count++;
            }

            int firstNum = 0;
            int secondNum = 0;
            int pow = (count + 1) / 2;

            firstNum = (int)(number / Math.Pow(10.0, pow * 1.0));
            secondNum = (int)(reversedNumber / Math.Pow(10.0, pow * 1.0));

            if (firstNum == secondNum)
            {
                return true;
            }

            return false;
        }
    }
}
