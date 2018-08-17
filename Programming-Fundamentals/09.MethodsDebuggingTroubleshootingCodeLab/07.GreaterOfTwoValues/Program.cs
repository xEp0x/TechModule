namespace _07.GreaterOfTwoValues
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            Console.WriteLine(GetGreaterValue(valueType));

        }

        static string GetGreaterValue(string valueType)
        {
            string greaterValue = string.Empty;

            switch (valueType)
            {
                case "int":
                    greaterValue = GetGreaterInt().ToString();
                    break;
                case "char":
                    greaterValue = getGreaterChar().ToString();
                    break;
                case "string":
                    greaterValue = getGreaterString();
                    break;
                default:
                    Console.WriteLine("Wrong type");
                    break;
            }

            return greaterValue;
        }

        static string getGreaterString()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();           

            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            else
            {
                return str2;
            }            
        }

        static char getGreaterChar()
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            char result = ' ';

            if (char1 >= char2)
            {
                result = char1;
            }
            else
            {
                result = char2;
            }

            return result;
        }

        static int GetGreaterInt()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = Math.Max(num1, num2);

            return result;
        }
    }
}
