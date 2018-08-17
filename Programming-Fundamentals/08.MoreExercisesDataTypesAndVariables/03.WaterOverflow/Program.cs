using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int numberOfLines = int.Parse(Console.ReadLine());
            int quantitySammury = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                //capacity -= quantity;                

                if (capacity < quantity)
                {
                    Console.WriteLine("Insufficient capacity!");
                
                }
                else
                {
                    capacity -= quantity;                  
                    quantitySammury += quantity;
                }

            }

            Console.WriteLine($"{quantitySammury}");
        }
    }
}
