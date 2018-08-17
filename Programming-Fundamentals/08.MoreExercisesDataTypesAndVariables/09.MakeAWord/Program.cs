using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int letterCount = int.Parse(Console.ReadLine());
            string outputWord = string.Empty;

            for (int i = 0; i < letterCount; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                outputWord += letter;
            }

            Console.WriteLine($"The word is: {outputWord}");
        }
    }
}

