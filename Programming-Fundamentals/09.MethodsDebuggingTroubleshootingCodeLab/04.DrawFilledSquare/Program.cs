namespace _04.DrawFilledSquare
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            DrawSquare(number);
        }

        private static void DrawSquare(int number)
        {
            DrawHeaderFooterRow(number);
            DrawMiddlePart(number);
            DrawHeaderFooterRow(number);
        }

        static void DrawMiddlePart(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                DrawMiddleRow(number);
                Console.WriteLine();
            }
        }

        static void DrawMiddleRow(int number)
        {
            Console.Write('-');
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.Write('-');
        }

        static void DrawHeaderFooterRow(int number)
        {
            string str = string.Empty;
            str = new string('-', 2 * number);
            Console.WriteLine(str);
        }
    }
}
