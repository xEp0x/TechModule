using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            char[] stringForCheck = inputNumber.ToCharArray();

            foreach (char ch in stringForCheck)
            {
                if (ch == '.')
                {
                    Console.WriteLine("floating-point");
                    return;
                }
            }

            Console.WriteLine("integer");

        }
    }
}
