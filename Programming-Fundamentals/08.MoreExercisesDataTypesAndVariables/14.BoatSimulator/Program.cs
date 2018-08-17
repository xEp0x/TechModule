using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatCharacter = char.Parse(Console.ReadLine());
            char secondBoatCharacter = char.Parse(Console.ReadLine());
            int linesCount = int.Parse(Console.ReadLine());
            int firstBoatMoveCounter = 0;
            int secondBoatMoveCounter = 0;

            for (int i = 1; i <= linesCount; i++)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand == "UPGRADE")
                {
                    firstBoatCharacter += (char)(3);
                    secondBoatCharacter += (char)(3);
                }
                else
                {
                    if (i % 2 == 1) //even
                    {
                        firstBoatMoveCounter += inputCommand.Length;
                    }
                    else //odd
                    {
                        secondBoatMoveCounter += inputCommand.Length;
                    }
                }

                if (firstBoatMoveCounter >= 50 || secondBoatMoveCounter >= 50)
                {
                    if (firstBoatMoveCounter > secondBoatMoveCounter)
                    {
                        Console.WriteLine(firstBoatCharacter);
                    }
                    else
                    {
                        Console.WriteLine(secondBoatCharacter);
                    }
                    return;
                }

            }

            if (firstBoatMoveCounter > secondBoatMoveCounter)
            {
                Console.WriteLine(firstBoatCharacter);
            }
            else
            {
                Console.WriteLine(secondBoatCharacter);
            }

        }
    }
}
