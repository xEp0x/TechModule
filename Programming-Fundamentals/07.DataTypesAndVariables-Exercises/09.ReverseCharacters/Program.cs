using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] letters = new char[3];
           
            for (int i = 2; i >= 0; i--)
            {
                char letter = char.Parse(Console.ReadLine());
                letters[i] = letter;
            }

            Console.WriteLine(new string(letters));

        }
    }
}
