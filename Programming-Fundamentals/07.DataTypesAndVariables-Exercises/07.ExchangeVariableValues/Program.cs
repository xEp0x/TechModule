using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int tempNumber = 0;

            tempNumber = a;
            a = b;
            b = tempNumber;

            Console.WriteLine($"Before:\na = 5\nb = 10");
            Console.WriteLine($"After:\na = 10\nb = 5");

        }
    }
}
