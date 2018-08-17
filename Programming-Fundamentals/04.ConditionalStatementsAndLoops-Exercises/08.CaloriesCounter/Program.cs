using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var productCount = int.Parse(Console.ReadLine());
            var cheeseCalories = 500;
            var tomatoSauceCalories = 150;
            var salamiCalories = 600;
            var pepperCalories = 50;
            var totalCalories = 0;

            for (int i = 0; i < productCount; i++)
            {
                var product = Console.ReadLine().ToLower();
                switch (product)
                {
                    case "cheese":
                        totalCalories += cheeseCalories;
                        break;
                    case "tomato sauce":
                        totalCalories += tomatoSauceCalories;
                        break;
                    case "salami":
                        totalCalories += salamiCalories;
                        break;
                    case "pepper":
                        totalCalories += pepperCalories;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
