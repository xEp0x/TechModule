namespace _07._1.GreaterOfTwoValues
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int maxInt = GetMax(num1, num2);
                    Console.WriteLine(maxInt);
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(ch1, ch2);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string maxString = GetMax(str1, str2);
                    Console.WriteLine(maxString);
                    break;
                default:
                    Console.WriteLine("Wrong type");
                    break;
            }            
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }

        static char GetMax(char ch1, char ch2)
        {
            if (ch1 >= ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 >= num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}