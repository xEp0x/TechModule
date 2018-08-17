using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int count = 0;
            decimal sum = 0m;

            while (count < numbersCount)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
                count++;
            }

            Console.WriteLine(sum);

        }
    }
}
