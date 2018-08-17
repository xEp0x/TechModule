using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] alphabet = new char[26];
            string outputString = string.Empty;

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
            }

            for (int i = 0; i < number; i++)
            {
                string characterNum = (Console.ReadLine());
                int digitsNumber = characterNum.Length;                
                int digit = int.Parse(characterNum[0].ToString());
                int offset = (digit - 2) * 3;
                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int position = offset + digitsNumber - 1;
                if (digit == 0)
                {
                    outputString += " ";
                }
                else
                {                    
                    outputString += alphabet[position].ToString();
                }                
            }

            Console.WriteLine(outputString);

        }
    }
}
