using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] products = Console.ReadLine().Split(delimiter).ToArray();
            long[] enteredQuantities = Console.ReadLine().Split(delimiter).Select(long.Parse).ToArray();
            long[] quantities = new long[products.Length];
            decimal[] prices = Console.ReadLine().Split(delimiter).Select(decimal.Parse).ToArray();
            List<string> outputMessages = new List<string>();

            AddZeroToEndOfQuantities(enteredQuantities, quantities);

            string[] command = Console.ReadLine().Split(delimiter).ToArray();

            while (!command[0].Equals("done"))
            {
                int index = Array.IndexOf(products, command[0]);
                long quantityInStore = quantities[index];
                long orderedQuantity = long.Parse(command[1]);
                bool isEnough = quantityInStore >= orderedQuantity;

                CalcIsEnoughInStore(products, quantities, prices, outputMessages, index, orderedQuantity, isEnough);

                command = Console.ReadLine().Split(delimiter).ToArray();
            }

            foreach (string item in outputMessages)
            {
                Console.WriteLine(item);
            }

        }

        static void CalcIsEnoughInStore(string[] products, long[] quantities, decimal[] prices, List<string> outputMessages, int index, long orderedQuantity, bool isEnough)
        {
            if (isEnough)
            {
                decimal totalPrice = orderedQuantity * prices[index];
                string message = $"{products[index]} x {orderedQuantity} costs {totalPrice:F2}";
                outputMessages.Add(message);
                quantities[index] -= orderedQuantity;
            }
            else
            {
                string message = $"We do not have enough {products[index]}";
                outputMessages.Add(message);
            }
        }

        static void AddZeroToEndOfQuantities(long[] enteredQuantities, long[] quantities)
        {
            int diff = quantities.Length - enteredQuantities.Length;
            for (int i = 0; i < enteredQuantities.Length; i++)
            {
                quantities[i] = enteredQuantities[i];
            }

            for (int i = quantities.Length - diff; i < quantities.Length; i++)
            {
                quantities[i] = 0;
            }
        }
    }
}
