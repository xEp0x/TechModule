using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestsCount = int.Parse(Console.ReadLine());
            decimal bananaPriceUnit = decimal.Parse(Console.ReadLine());
            decimal eggPriceUnit = decimal.Parse(Console.ReadLine());
            decimal berryPriceKilo = decimal.Parse(Console.ReadLine());

            int dessertSetCount = guestsCount % 6 == 0 ?
                guestsCount / 6 :
                guestsCount / 6 + 1;

            //int dessertSetCount = Math.Ceiling(guestCount/6);

            decimal allBananaPrice = bananaPriceUnit * dessertSetCount * 2;
            decimal allEggPrice = eggPriceUnit * dessertSetCount * 4;
            decimal allBerryPrice = berryPriceKilo * dessertSetCount * 0.2m;

            decimal allProductsPrice = allBananaPrice + allEggPrice + allBerryPrice;
            var diff = Math.Abs(cash - allProductsPrice);


            Console.WriteLine(
                cash >= allProductsPrice ?
                $"Ivancho has enough money - it would cost {allProductsPrice:F2}lv." :
                $"Ivancho will have to withdraw money - he will need {diff:F2}lv more.");
        }
    }
}
