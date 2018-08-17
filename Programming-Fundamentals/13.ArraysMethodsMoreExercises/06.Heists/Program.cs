using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            const char delimiter = ' ';

            int[] prices = Console.ReadLine().Split(delimiter).Select(int.Parse).ToArray();
            int jewelsPrice = prices[0];
            int goldPrice = prices[1];

            char jewelsSymbol = '%';
            char goldSymbol = '$';

            long totalExpenses = 0;
            long totalEarnings = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split(delimiter).ToArray();

                if (command[0].Equals("Jail") && command[1].Equals("Time"))
                {
                    break;
                }

                foreach (char item in command[0])
                {
                    if (item == jewelsSymbol)
                    {
                        totalEarnings += jewelsPrice;
                    }
                    else if (item == goldSymbol)
                    {
                        totalEarnings += goldPrice;
                    }
                }

                totalExpenses += int.Parse(command[1]);
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }

        }
    }
}
