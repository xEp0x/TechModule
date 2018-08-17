using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbolNumber = int.Parse(Console.ReadLine());
            int secondSymbolNumber = int.Parse(Console.ReadLine());
            string outputString = string.Empty;

            for (int i = firstSymbolNumber; i <= secondSymbolNumber; i++)
            {
                outputString += (char)i + " ";
            }

            Console.WriteLine(outputString.Remove(outputString.Length-1));
        }
    }
}
