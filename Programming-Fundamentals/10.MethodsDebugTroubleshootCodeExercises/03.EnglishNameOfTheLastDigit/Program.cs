namespace _03.EnglishNameOfTheLastDigit
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            long lastDigit = GetLastDigit(number);
            string lastDigitWord = ConvertDigitToWord(lastDigit);
            Console.WriteLine(lastDigitWord);
        }

        static string ConvertDigitToWord(long lastDigit)
        {
            string digitWord = string.Empty;

            switch (lastDigit)
            {
                case 1:
                    digitWord = "one";
                    break;
                case 2:
                    digitWord = "two";
                    break;
                case 3:
                    digitWord = "three";
                    break;
                case 4:
                    digitWord = "four";
                    break;
                case 5:
                    digitWord = "five";
                    break;
                case 6:
                    digitWord = "six";
                    break;
                case 7:
                    digitWord = "seven";
                    break;
                case 8:
                    digitWord = "eight";
                    break;
                case 9:
                    digitWord = "nine";
                    break;
                case 0:
                    digitWord = "zero";
                    break;
                default:
                    Console.WriteLine("No such digit");
                    break;                   
            }

            return digitWord;
        }

        static long GetLastDigit(long number)
        {
            long lastDigit = Math.Abs(number) % 10;

            return lastDigit;
        }
    }
}