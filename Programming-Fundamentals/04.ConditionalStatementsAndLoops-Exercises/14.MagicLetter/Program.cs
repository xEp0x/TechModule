using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char exeptionLetter = char.Parse(Console.ReadLine());
            string str = string.Empty;

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (k == exeptionLetter || j == exeptionLetter || i == exeptionLetter)
                        {
                            continue;
                        }
                        else
                        {
                            str = "" + i + j + k + " ";
                            Console.Write(str);
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
