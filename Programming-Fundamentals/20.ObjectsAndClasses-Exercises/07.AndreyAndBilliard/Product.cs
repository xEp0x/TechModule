using System;

namespace _07.AndreyAndBilliard
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        //Product name-Product price
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
