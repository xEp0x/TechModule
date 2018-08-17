using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesCount = int.Parse(Console.ReadLine());
            var listOfSales = new List<Sale>();
            var townSales = new SortedDictionary<string, decimal>();

            ReadAllSales(salesCount, listOfSales);
            CalcSalesPerTown(listOfSales, townSales);

            foreach (var townSale in townSales)
            {
                Console.WriteLine($"{townSale.Key} -> {townSale.Value:F2}");
            }
        }

        static void CalcSalesPerTown(List<Sale> listOfSales, SortedDictionary<string, decimal> townSales)
        {
            foreach (var sale in listOfSales)
            {
                if (!townSales.ContainsKey(sale.Town))
                {
                    townSales[sale.Town] = 0m;
                }

                var currentSale = sale.Price * sale.Quantity;
                townSales[sale.Town] += currentSale;
            }
        }

        static void ReadAllSales(int salesCount, List<Sale> listOfSales)
        {
            for (int i = 0; i < salesCount; i++)
            {
                var inputLine = Console.ReadLine().Split().ToList();
                var town = inputLine[0];
                var product = inputLine[1];
                var price = decimal.Parse(inputLine[2]);
                var quantity = decimal.Parse(inputLine[3]);

                Sale currentSale = new Sale
                {
                    Town = town,
                    Product = product,
                    Price = price,
                    Quantity = quantity
                };
                listOfSales.Add(currentSale);
            }
        }
    }
}
