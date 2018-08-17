namespace _04.NumbersInReversedOrder
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            string outputNumber = ReverseDigitsOrder(number);
            Console.WriteLine(outputNumber);
        }

        static string ReverseDigitsOrder(double number)
        {
            string str = string.Empty;
            char[] numberDigits = number.ToString().ToCharArray();

            for (int i = numberDigits.Length - 1; i >= 0; i--)
            {
                str += numberDigits[i];

            }

            return str;
        }
    }
}
