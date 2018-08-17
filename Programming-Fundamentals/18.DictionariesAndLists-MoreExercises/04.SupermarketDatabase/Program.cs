using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var productPriceQuantity = new Dictionary<string, List<double>>();
            string line = Console.ReadLine();

            while (line != "stocked")
            {
                var input = line.Split().ToList();
                var product = input[0];
                var price = double.Parse(input[1]);
                var quantity = double.Parse(input[2]);

                var priceQuantity = new List<double>();


                if (!productPriceQuantity.ContainsKey(product))
                {
                    productPriceQuantity[product] = new List<double>();
                    priceQuantity.Add(price);
                    priceQuantity.Add(quantity);
                    productPriceQuantity[product].AddRange(priceQuantity);
                }
                else
                {
                    var inStock = productPriceQuantity[product];
                    quantity += inStock[1];
                    priceQuantity.Add(price);
                    priceQuantity.Add(quantity);
                    productPriceQuantity[product] = priceQuantity;
                }

                line = Console.ReadLine();
            }

            CalcTotalPrice(productPriceQuantity);

            double grandTotal = PrintProductPriceQuantity(productPriceQuantity);

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }

        static double PrintProductPriceQuantity(Dictionary<string, List<double>> productPriceQuantity)
        {
            var grandTotal = 0.0;

            foreach (var prodPriceQuant in productPriceQuantity)
            {
                var product = prodPriceQuant.Key;
                var priceQuantity = prodPriceQuant.Value;
                var price = priceQuantity[0];
                var quantity = priceQuantity[1];
                var totalPrice = priceQuantity[2];
                Console.WriteLine($"{product}: ${price:F2} * {quantity} = ${totalPrice:F2}");
                grandTotal += totalPrice;
            }

            return grandTotal;
        }

        static void CalcTotalPrice(Dictionary<string, List<double>> productPriceQuantity)
        {
            foreach (var pair in productPriceQuantity)
            {
                var productPriceTotal = productPriceQuantity[pair.Key];
                var currentPrice = productPriceTotal[0];
                var currentQuantity = productPriceTotal[1];
                var totalProductPrice = currentPrice * currentQuantity;
                productPriceTotal.Add(totalProductPrice);
            }

        }
    }
}
