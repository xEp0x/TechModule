using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialHealth = int.Parse(Console.ReadLine());
            var maxHealth = initialHealth;
            string input = Console.ReadLine();
            var virusEncounter = new List<string>();

            while (input != "end")
            {                
                var virusName = input;
                var virusStrength = CalcVirusStrength(virusName);
                var virusDefeatSeconds = virusName.Length * virusStrength;
                var timeToDefeat = CalcTimeToDefeatMinSec(virusDefeatSeconds);

                if (!virusEncounter.Contains(virusName))
                {
                    virusEncounter.Add(virusName);

                }
                else
                {
                    virusDefeatSeconds = (int)(virusDefeatSeconds / 3.0);
                    timeToDefeat = CalcTimeToDefeatMinSec(virusDefeatSeconds);                    
                }

                initialHealth -= virusDefeatSeconds;

                Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusDefeatSeconds} seconds");
                if (initialHealth <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

                Console.WriteLine($"{virusName} defeated in {timeToDefeat}.");
                Console.WriteLine($"Remaining health: {initialHealth}");

                initialHealth = (int)(initialHealth * 1.2);
                initialHealth = Math.Min(initialHealth, maxHealth);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {initialHealth}");
        }

        static string CalcTimeToDefeatMinSec(int virusDefeatSeconds)
        {
            var minutes = virusDefeatSeconds / 60;
            var seconds = virusDefeatSeconds % 60;
            var timeToDefeat = minutes + "m " + seconds + "s";

            return timeToDefeat;
        }

        static int CalcVirusStrength(string virusName)
        {
            var virusStrength = 0;
            var virusCharacters = virusName.ToCharArray();

            foreach (var character in virusCharacters)
            {
                virusStrength += (int)character;
            }

            virusStrength = (int)(virusStrength / 3.0);

            return virusStrength;
        }
    }
}
