using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] arr = Console.ReadLine().Split(delimiter).ToArray();

            for (int i = 0; i < arr.Length/2; i++)
            {
                string tempString = string.Empty;
                tempString = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tempString;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
