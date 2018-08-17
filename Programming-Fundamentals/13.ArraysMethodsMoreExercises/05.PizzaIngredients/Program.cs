using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            string[] ingredients = Console.ReadLine().Split(delimiter).ToArray();
            int lengthLimit = int.Parse(Console.ReadLine());
            int counter = 0;
            int ingredCounter = 1;
            List<string> pizza = new List<string>();

            while (counter < ingredients.Length)
            {
                //char[] ingredient = ingredients[ingredCount].ToCharArray();

                if (ingredients[counter].Length == lengthLimit)
                {
                    if (ingredCounter > 10)
                    {
                        break;
                    }
                    Console.WriteLine($"Adding {ingredients[counter]}.");
                    ingredCounter++;
                    pizza.Add(ingredients[counter]);
                }

                counter++;
            }

            Console.WriteLine($"Made pizza with total of {pizza.Count} ingredients.");
            string[] pizzaIngred = pizza.ToArray();
            Console.WriteLine("The ingredients are: " + string.Join(", ", pizzaIngred) + ".");
        }
    }
}
