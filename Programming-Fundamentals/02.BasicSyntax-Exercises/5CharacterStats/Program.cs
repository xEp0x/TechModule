using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var currentHealthString = new string('|', currentHealth);
            var missingHealthString = new string('.', maxHealth - currentHealth);
            var currentEnergyString = new string('|', currentEnergy);
            var missingEnergyString = new string('.', maxEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealthString}{missingHealthString}|");
            Console.WriteLine($"Energy: |{currentEnergyString}{missingEnergyString}|");
        }
    }
}
