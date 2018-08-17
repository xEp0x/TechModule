using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            minute += 30;

            if (minute >= 60)
            {
                hour++;
                minute -= 60;
                if (hour == 24)
                {
                    hour = 0;
                }
            }

            Console.WriteLine($"{hour}:{minute:D2}");

        }
    }
}
