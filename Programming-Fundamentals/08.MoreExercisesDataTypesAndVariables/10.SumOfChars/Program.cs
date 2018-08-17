using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int charactersCount = int.Parse(Console.ReadLine());
            int sumOfCharacters = 0;

            for (int i = 0; i < charactersCount; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sumOfCharacters += character;
            }

            Console.WriteLine($"The sum equals: {sumOfCharacters}");
        }
    }
}
