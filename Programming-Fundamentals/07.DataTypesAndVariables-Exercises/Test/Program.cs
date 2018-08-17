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
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            long result = (long)num1 * num2;
            long result1 = (long)(num1 * num2);


            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(result);
            Console.WriteLine(result1);

        }
    }
}
