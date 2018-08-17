using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new List<string> { "@nakov", "@royal", " @ROYAL", "@ivo" };

            var sorted = test.OrderBy(e => e).ToList();

            Console.WriteLine();
        }
    }
}
