using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var startNum = Math.Min(num1, num2);
            var endNum = Math.Max(num1, num2);

            for (int i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
