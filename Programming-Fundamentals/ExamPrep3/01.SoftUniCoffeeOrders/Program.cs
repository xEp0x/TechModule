using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace _01.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var orderCount = int.Parse(Console.ReadLine());
            decimal sumAllOrderPrice = 0m;

            for (decimal i = 0; i < orderCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsuleCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var orderPrice = pricePerCapsule * capsuleCount * daysInMonth;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                sumAllOrderPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${sumAllOrderPrice:F2}");
        }
    }
}
