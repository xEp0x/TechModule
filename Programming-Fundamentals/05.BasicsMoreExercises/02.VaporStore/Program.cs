using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());            
            var gameName = Console.ReadLine();
            bool isEndBying = true;

            var outfallPrice = 39.99;
            var csPrice = 15.99;
            var zplinterPrice = 19.99;
            var honoredPrice = 59.99;
            var roverPrice = 29.99;
            var roverOriginalPrice = 39.99;
            var spent = 0.0;

            while (isEndBying)
            {
                if (gameName.Equals("Game Time"))
                {
                    if (budget == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${budget:F2}");
                        break;
                    }                        
                }

                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }                                                    
               
                    switch (gameName)
                    {
                        case "OutFall 4":
                        if (budget < outfallPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= outfallPrice;
                            spent += outfallPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        case "CS: OG":
                        if (budget < csPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= csPrice;
                            spent += csPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        case "Zplinter Zell":
                        if (budget < zplinterPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= zplinterPrice;
                            spent += zplinterPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        case "Honored 2":
                        if (budget < honoredPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= honoredPrice;
                            spent += honoredPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        case "RoverWatch":
                        if (budget < roverPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= roverPrice;
                            spent += roverPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        case "RoverWatch Origins Edition":
                        if (budget < roverOriginalPrice)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            budget -= roverOriginalPrice;
                            spent += roverOriginalPrice;
                            Console.WriteLine($"Bought {gameName}");
                        }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    
                }
                
                gameName = Console.ReadLine();

            }


        }
    }
}
