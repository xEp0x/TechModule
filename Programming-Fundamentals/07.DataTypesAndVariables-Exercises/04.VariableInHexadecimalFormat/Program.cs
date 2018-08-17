using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numHex1 = Console.ReadLine();
            int outputNumber = Convert.ToInt32(numHex1, 16);
            
            Console.WriteLine(outputNumber);           

        }
    }
}
