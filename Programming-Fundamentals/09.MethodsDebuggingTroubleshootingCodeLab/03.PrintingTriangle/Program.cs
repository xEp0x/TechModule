namespace _03.PrintingTriangle
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberTriangle(number);            
        }

        static void PrintNumberTriangle(int num)
        {
            PrintUpperTriangle(num);
            PrintLowerTriangle(num);
        }

        static void PrintLowerTriangle(int num)
        {
            for (int i = num - 1; i > 0; i--)
            {
                PrintRow(1, i);
            }
        }

        static void PrintUpperTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintRow(1, i);
            }
        }

        static void PrintRow(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}