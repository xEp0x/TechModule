using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var half = number / 2;

            //Top half
            for (int i = 0; i < half; i++)
            {
                Console.WriteLine(draw(" ", i) + "x" + draw(" ", number - 2 * (1 + i)) + "x");
            }

            //Middle part
            Console.WriteLine(draw(" ", half) + "x");

            //Bottom half
            for (int i = 0; i < half; i++)
            {
                Console.WriteLine(draw(" ", half - 1 - i) + "x" + draw(" ", 2 * i + 1)  + "x");
            }

        }

        public static String draw(string str, int count)
        {
            StringBuilder str1 = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                str1.Append(str);
            }

            return str1.ToString();
        }

    }
}
