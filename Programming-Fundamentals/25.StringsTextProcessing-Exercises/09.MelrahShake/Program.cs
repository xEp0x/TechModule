using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var pattern = Console.ReadLine();
            var veryFirstIndex = 0;
            var veryLastIndex = 0;

            while (true)
            {
                veryFirstIndex = inputString.IndexOf(pattern);
                veryLastIndex = inputString.LastIndexOf(pattern);

                if ((veryFirstIndex == -1 && veryLastIndex == -1) || veryFirstIndex == veryLastIndex || pattern.Length==0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                inputString = inputString.Remove(veryFirstIndex, pattern.Length);
                inputString = inputString.Remove(veryLastIndex - pattern.Length, pattern.Length);
                Console.WriteLine("Shaked it.");

                var indexCharForRemove = pattern.Length / 2;
                pattern = pattern.Remove(indexCharForRemove, 1);
            }

            Console.WriteLine(inputString);
        }
    }
}
