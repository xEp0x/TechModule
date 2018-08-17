using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());                                    

            for (int i = 1; i <= num; i++)
            {
                int sumDigits = 0;
                bool isCurrentNumberSpecial = false;
                int currenNumber = i;
                while (currenNumber > 0)
                {
                    sumDigits += currenNumber % 10;
                    currenNumber = currenNumber / 10;
                }

                isCurrentNumberSpecial = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);

                Console.WriteLine($"{i} -> {isCurrentNumberSpecial}");                              
            }

        }
    }
}
