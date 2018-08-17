namespace _06.PrimeChecker
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            bool isPrime = isPrimeNumber(number);
            Console.WriteLine(isPrime);
        }

        static bool isPrimeNumber(long number)
        {
            bool isPrime = true;

            if (number == 0 || number == 1)
            {
                isPrime = false;
                return isPrime;
            }

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }
            }

            return isPrime;
        }
    }
}
