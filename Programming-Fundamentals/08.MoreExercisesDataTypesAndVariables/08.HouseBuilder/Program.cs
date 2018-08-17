using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long priceMaterials1 = int.Parse(Console.ReadLine());
            long priceMaterials2 = int.Parse(Console.ReadLine());
            long sbytePrice = 0;
            long intPrice = 0;
            long totalPrice = 0;

            bool isMaterialSbyte = priceMaterials1 < priceMaterials2;

            if (isMaterialSbyte)
            {
                sbytePrice = priceMaterials1;
                intPrice = priceMaterials2;
            }
            else
            {
                sbytePrice = priceMaterials2;
                intPrice = priceMaterials1;
            }

            totalPrice = 4 * sbytePrice + 10 * intPrice;
            Console.WriteLine(totalPrice);

        }
    }
}
