using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.DayОfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // First Method
            //  var inputLine = Console.ReadLine();
            //  DateTime date = DateTime.ParseExact(inputLine, "d-M-yyyy", CultureInfo.InvariantCulture);
            //  Console.WriteLine(date.DayOfWeek);


            // Second Method
            var inputLine = Console.ReadLine().Split('-');
            var day = int.Parse(inputLine[0]);
            var month = int.Parse(inputLine[1]);
            var year = int.Parse(inputLine[2]);

            DateTime date = new DateTime(year, month, day);
            Console.WriteLine(date.DayOfWeek);


        }
    }
}
