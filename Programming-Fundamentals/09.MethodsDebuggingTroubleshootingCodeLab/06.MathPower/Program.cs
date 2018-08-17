namespace _06.MathPower
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());

            double resultMathPower = GetMathPower(baseNumber, powerNumber);
            Console.WriteLine(resultMathPower);
        }

        static double GetMathPower(double baseNumber, int powerNumber)
        {
            double result = 1;
            for (int i = 1; i <= powerNumber; i++)
            {
                result *= baseNumber;
            }
            return result;
        }
    }
}
