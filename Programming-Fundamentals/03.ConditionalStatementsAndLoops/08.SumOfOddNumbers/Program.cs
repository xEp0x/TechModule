using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var evenNumber = 1;
            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(evenNumber);
                sum += evenNumber;
                evenNumber += 2;                
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
