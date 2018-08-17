using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intCount = 0;
            while (true)
            {
                try
                {
                    var number = int.Parse(Console.ReadLine());
                    intCount++;
                }
                catch (Exception e)
                {
                    break;
                }
            }

            Console.WriteLine(intCount);
        }
    }
}
