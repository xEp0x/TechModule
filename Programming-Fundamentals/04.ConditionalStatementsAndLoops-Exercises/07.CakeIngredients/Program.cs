using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine();
            var ingredientsCount = 0;
            bool isBake = true;

            while (isBake)
            {
                ingredientsCount++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine();
                if (ingredient.Equals("Bake!"))
                {
                    isBake = false;
                }
            }

            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");

        }
    }
}
