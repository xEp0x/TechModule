using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem_
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var factor = int.Parse(Console.ReadLine());

            var halfPower = 0;

            if (power % 2 == 0)
            {
                halfPower = power / 2;
            }

            var count = 0;

            while (power >= distance)
            {
                power -= distance;
                count++;

                if (power == halfPower && factor != 0)
                {
                    power = power / factor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}
