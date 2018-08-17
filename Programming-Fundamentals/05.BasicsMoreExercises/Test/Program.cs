using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            char[] alphabet = new char[26];
            string outputString = string.Empty;

            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = (char)(i + 97);
                Console.WriteLine(alphabet[i]);
            }

        }
    }
}
