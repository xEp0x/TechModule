using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleCount = int.Parse(Console.ReadLine());
            var servicePackage = Console.ReadLine().ToLower();
            var smallHall = 2500;
            var terrace = 5000;
            var greatHall = 7500;
            var normalPackage = 500;
            var goldPackage = 750;
            var platinumPackage = 1000;
            var totalPrice = 0.0;
            var hallName = "";

            if (peopleCount <= 50)
            {
                switch (servicePackage)
                {
                    case "normal":
                        totalPrice = ((smallHall + normalPackage) - (smallHall + normalPackage) * 5.0 / 100.0) / peopleCount;                        
                        break;
                    case "gold":
                        totalPrice = ((smallHall + goldPackage) - (smallHall + goldPackage) * 10.0 / 100.0) / peopleCount;                        
                        break;
                    case "platinum":
                        totalPrice = ((smallHall + platinumPackage) - (smallHall + platinumPackage) * 15.0 / 100.0) / peopleCount;                        
                        break;
                }
                hallName = "Small Hall";
            }
            else
            {
                if (peopleCount <= 100)
                {
                    switch (servicePackage)
                    {
                        case "normal":
                            totalPrice = ((terrace + normalPackage) - (terrace + normalPackage) * 5.0 / 100.0) / peopleCount;                           
                            break;
                        case "gold":
                            totalPrice = ((terrace + goldPackage) - (terrace + goldPackage) * 10.0 / 100.0) / peopleCount;                            
                            break;
                        case "platinum":
                            totalPrice = ((terrace + platinumPackage) - (terrace + platinumPackage) * 15.0 / 100.0) / peopleCount;                            
                            break;
                    }
                    hallName = "Terrace";
                }
                else
                {
                    if (peopleCount <= 120)
                    {
                        switch (servicePackage)
                        {
                            case "normal":
                                totalPrice = ((greatHall + normalPackage) - (greatHall + normalPackage) * 5.0 / 100.0) / peopleCount;
                                break;
                            case "gold":
                                totalPrice = ((greatHall + goldPackage) - (greatHall + goldPackage) * 10.0 / 100.0) / peopleCount;
                                break;
                            case "platinum":
                                totalPrice = ((greatHall + platinumPackage) - (greatHall + platinumPackage) * 15.0 / 100.0) / peopleCount;                                
                                break;
                        }
                        hallName = "Great Hall";
                    }                    
                }
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice:F2}$");
            }
        }
    }
}
