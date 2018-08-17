using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //string numberHex = number.ToString("X");
            string numberHex = Convert.ToString(number, 16).ToUpper();
            string numberBin = Convert.ToString(number, 2);

            Console.WriteLine(numberHex);
            Console.WriteLine(numberBin);

        }
    }
}
