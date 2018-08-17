using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            var productCount = int.Parse(Console.ReadLine());
            var products = new List<Product>();
            var customers = new List<Customer>();

            InputProductsData(productCount, products);

            var inputLine = Console.ReadLine();

            while (inputLine != "end of clients")
            {
                char[] delimiters = { '-', ',' };

                var customerInfo = inputLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                var currentCustomerName = customerInfo[0];
                var currentCustomerProduct = customerInfo[1];
                var currentCustomerProdQuantity = int.Parse(customerInfo[2]);

                var item = products.FirstOrDefault(pr => pr.Name == currentCustomerProduct);

                if (item == null)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var itemCustomer = customers.FirstOrDefault(c => c.Name == currentCustomerName);

                if (itemCustomer == null)
                {
                    var order = new Dictionary<string, int>();
                    order.Add(currentCustomerProduct, currentCustomerProdQuantity);
                    var currentCustometBill = item.Price * currentCustomerProdQuantity;
                    Customer currentCustomer = new Customer(currentCustomerName, order, currentCustometBill);
                    customers.Add(currentCustomer);
                }
                else
                {
                    var order = new Dictionary<string, int>();
                    order = itemCustomer.Order;

                    if (!order.ContainsKey(currentCustomerProduct))
                    {
                        order.Add(currentCustomerProduct, currentCustomerProdQuantity);
                        itemCustomer.Order = order;
                        var currentCustometBill = item.Price * currentCustomerProdQuantity;
                        itemCustomer.Bill += currentCustometBill;
                    }
                    else
                    {
                        order[currentCustomerProduct] += currentCustomerProdQuantity;
                        itemCustomer.Order = order;
                        var currentCustometBill = item.Price * currentCustomerProdQuantity;
                        itemCustomer.Bill += currentCustometBill;
                    }
                }

                inputLine = Console.ReadLine();
            }

            PrintOutput(customers);
        }

        static void PrintOutput(List<Customer> customers)
        {
            var sortedCustomers = customers.OrderBy(c => c.Name).ToList();
            var totalBill = 0m;

            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine(customer.Name);
                foreach (var product in customer.Order)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        static void InputProductsData(int productCount, List<Product> products)
        {
            const char delimiter = '-';

            for (int i = 0; i < productCount; i++)
            {
                var inputLine = Console.ReadLine().Split(delimiter);
                var currentProductName = inputLine[0];
                var currentProductPrice = decimal.Parse(inputLine[1]);
                Product currentProduct = new Product(currentProductName, currentProductPrice);

                var item = products.FirstOrDefault(pr => pr.Name == currentProductName);

                if (item != null)
                {
                    item.Price = currentProductPrice;
                }
                else
                {
                    products.Add(currentProduct);
                }
            }
        }
    }
}
