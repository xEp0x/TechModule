using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char ch in inputString)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)ch)); // :x - HEX format 4 digits 0000
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
