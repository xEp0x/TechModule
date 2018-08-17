using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            string peshoAttack = "Roundhouse kick";
            string goshoAttack = "Thunderous fist";
            int turnCounter = 1;
            string winnerName = string.Empty;
            bool isAnyoneDead = false; //peshoHealth <= 0 || goshoHealth <= 0

            while (!isAnyoneDead)
            {
                if (turnCounter % 2 == 1) //odd turn
                {
                    goshoHealth -= peshoDamage;                    
                    if (goshoHealth <= 0)
                    {
                        winnerName = "Pesho";
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used {peshoAttack} and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else //even turn
                {
                    peshoHealth -= goshoDamage;                    
                    if (peshoHealth <= 0)
                    {
                        winnerName = "Gosho";
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used {goshoAttack} and reduced Pesho to {peshoHealth} health.");
                    }
                }

                if (turnCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                turnCounter++;

                isAnyoneDead = peshoHealth <= 0 || goshoHealth <= 0;
            }

            Console.WriteLine($"{winnerName} won in {turnCounter}th round.");           

        }
    }
}
