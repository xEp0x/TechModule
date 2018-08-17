namespace _02.MaxMethod
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int maxOneAndTwo = GetMaxTwoNumbers(number1, number2);
            int maxTwoAndThree = GetMaxTwoNumbers(number2, number3);
            int maxNumber = GetMaxTwoNumbers(maxOneAndTwo, maxTwoAndThree);

            Console.WriteLine(maxNumber);
        }

        static int GetMaxTwoNumbers(int number1, int number2)
        {
            int maxNumber = Math.Max(number1, number2);

            return maxNumber;
        }
    }
}