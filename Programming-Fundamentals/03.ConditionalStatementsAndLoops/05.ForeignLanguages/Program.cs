using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "england":
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
