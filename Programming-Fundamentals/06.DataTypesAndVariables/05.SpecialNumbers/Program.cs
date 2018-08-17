using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberCount; i++)
            {                
                bool isNumberSpecial = DigitsSum(i) == 5 || DigitsSum(i) == 7 || DigitsSum(i) == 11;
                if (isNumberSpecial)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }

        public static int DigitsSum(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            return sum;
        }
    }
}
