using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = new char[] { ':', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            string[] inputText = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string element in inputText)
            {
                bool isLowerCase = false;
                bool isUpperCase = false;

                isLowerCase = CheckWord(element, 'a', 'z');
                isUpperCase = CheckWord(element, 'A', 'Z');

                if (isLowerCase)
                {
                    lowerCase.Add(element);
                }
                else if (isUpperCase)
                {
                    upperCase.Add(element);
                }
                else
                {
                    mixedCase.Add(element);
                }
            }

            Console.WriteLine("Lower-case: " + String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + String.Join(", ", upperCase));

            Console.WriteLine();
        }

        static bool CheckWord(string element, char startChar, char endChar)
        {
            char[] word = element.ToCharArray();
            string tempWord = string.Empty;
            bool isCase = false;

            foreach (char item in word)
            {
                if (startChar<= item && item <= endChar)
                {
                    tempWord += item;
                }
                else
                {
                    break;
                }
            }

            if (element.Equals(tempWord))
            {
                isCase = true;
            }

            return isCase;
        }
    }
}
