using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            var namesPlates = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var command = input[0];


                if (command == "register")
                {
                    var name = input[1];
                    var plate = input[2];

                    if (namesPlates.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {namesPlates[name]}"); // s koj nomer e regnat
                        continue;
                    }
                    else
                    {
                        bool isPlateValid = CheckIsPlateValid(plate);
                        if (!isPlateValid)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {plate}");
                            continue;
                        }

                        bool isPlateBusy = false;
                        foreach (var namePlate in namesPlates)
                        {
                            var nameInPark = namePlate.Key;
                            var plateInPark = namePlate.Value;
                            if (plateInPark == plate)
                            {
                                Console.WriteLine($"ERROR: license plate {plateInPark} is busy");
                                isPlateBusy = true;
                                break;
                            }
                        }

                        if (isPlateBusy)
                        {
                            continue;
                        }

                        namesPlates[name] = plate;
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    var name = input[1];

                    if (namesPlates.ContainsKey(name))
                    {
                        namesPlates.Remove(name);
                        Console.WriteLine($"user {name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("No such command!");
                }
            }

            foreach (var namePlate in namesPlates)
            {
                var name = namePlate.Key;
                var plate = namePlate.Value;
                Console.WriteLine($"{name} => {plate}");
            }
        }

        static bool CheckIsPlateValid(string plate)
        {
            bool isPlateValid = true;
            var plateChars = plate.ToCharArray().ToList();

            if (plateChars.Count != 8)
            {
                return false;
            }

            var middlePlatePart = plateChars.Skip(2).Take(4).ToList();
            foreach (var character in middlePlatePart)
            {
                if (!Char.IsDigit(character))
                {
                    return false;
                }
            }

            var firstPart = plate.Take(2);
            var lastPart = plate.Reverse().Take(2).Reverse();
            var firstAndEndPart = firstPart.Concat(lastPart);            
            foreach (var character in firstAndEndPart)
            {
                if (!('A' <= character && character <= 'Z'))
                {
                    return false;
                }
            }

            return isPlateValid;
        }
    }
}

