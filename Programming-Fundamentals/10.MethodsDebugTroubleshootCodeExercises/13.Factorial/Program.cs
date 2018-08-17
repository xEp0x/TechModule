namespace _13.Factorial
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = CalcFactorial(number);

            Console.WriteLine(factorialNumber);
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
