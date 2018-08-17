namespace _05.FibonacciNumbers
{

    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long numberFibonacci = CalculateNumberFibonacci(number);

            //PrintFibonacciNumbers(number); //Print on the console all Fibonacci numbers till number

            Console.WriteLine(numberFibonacci); // Calculate Fibonacci number 

        }

        static void PrintFibonacciNumbers(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(CalculateNumberFibonacci(i));
            }
        }

        static long CalculateNumberFibonacci(int number)
        {
            int currentfibonacciNumber = 1;
            int previousFibonacciNumber = 1;
            int nextFibonacciNumber = 1;
            int count = 1;

            while (count < number)
            {
                nextFibonacciNumber = currentfibonacciNumber + previousFibonacciNumber;
                previousFibonacciNumber = currentfibonacciNumber;
                currentfibonacciNumber = nextFibonacciNumber;
                count++;
            }

            return nextFibonacciNumber;
        }
    }
}
