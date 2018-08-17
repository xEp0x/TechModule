using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] names = Console.ReadLine().Split(delimiter).ToArray();
            string[] quantities = Console.ReadLine().Split(delimiter).ToArray();
            string[] prices = Console.ReadLine().Split(delimiter).ToArray();
            List<int> indexes = new List<int>();

            string command = Console.ReadLine();

            while (!command.Equals("done"))
            {
                int index = Array.IndexOf(names, command);
                indexes.Add(index);

                command = Console.ReadLine();
            }

            foreach (int item in indexes)
            {
                Console.WriteLine($"{names[item]} costs: {prices[item]}; Available quantity: {quantities[item]}");
            }
        }
    }
}

