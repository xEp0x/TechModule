using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var beatsCount = int.Parse(Console.ReadLine());
            var minute = 0;
            var second = 0;

            var bars = beatsCount / 4.0;
            bars = Math.Round(bars, 1);

            var time = beatsCount * 60 / beatsPerMinute;
            if (time >= 60)
            {
                minute = time / 60;
                second = time % 60;
            }
            else
            {
                second = time;
            }

            Console.WriteLine($"{bars} bars - {minute}m {second}s");

        }
    }
}
