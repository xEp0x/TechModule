using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subTotal = 0.0;

            for (int i = 0; i < numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemNumber = int.Parse(Console.ReadLine());
                subTotal += itemNumber * itemPrice;
                if (itemNumber > 1)
                {
                    itemName += "s";
                }
                Console.WriteLine($"Adding {itemNumber} {itemName} to cart.");
            }

            Console.WriteLine($"Subtotal: ${subTotal:F2}");
            var diff = Math.Abs(budget - subTotal);
            if (subTotal <= budget)
            {
                Console.WriteLine($"Money left: ${diff:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${diff:F2} more.");
            }


        }
    }
}
