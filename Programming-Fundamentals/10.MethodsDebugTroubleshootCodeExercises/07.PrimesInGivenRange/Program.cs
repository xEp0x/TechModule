namespace _07.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());

            PrintPrimeNumbersInRange(startNumber, endNumber);
        }

        static void PrintPrimeNumbersInRange(long startNumber, long endNumber)
        {
            List<long> primeNumbersInRange = FindPrimesInRange(startNumber, endNumber);

            long lastElementInList = primeNumbersInRange.Last();

            foreach (long number in primeNumbersInRange)
            {

                if (number.Equals(lastElementInList))
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.Write(number + ", ");
                }
            }
        }

        static List<long> FindPrimesInRange(long startNumber, long endNumber)
        {
            List<long> primeNumbersInRange = new List<long>();

            for (long i = startNumber; i <= endNumber; i++)
            {

                if (isPrimeNumber(i))
                {
                    primeNumbersInRange.Add(i);
                }
            }

            return primeNumbersInRange;
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
