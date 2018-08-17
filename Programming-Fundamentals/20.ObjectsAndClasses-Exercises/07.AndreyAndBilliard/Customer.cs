using System;
using System.Collections.Generic;

namespace _07.AndreyAndBilliard
{
    public class Customer
    {
        public Customer(string name, Dictionary<string, int> order, decimal bill)
        {
            Name = name;
            Order = order;
            Bill = bill;
        }

        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill { get; set; }
    }
}
