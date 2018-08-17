using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class JarvisRobot
    {
        static void Main(string[] args)
        {
            Jarvis robot = new Jarvis();

            robot.Energy = long.Parse(Console.ReadLine());
            var inputLine = Console.ReadLine().Split();

            while (true)
            {                
                if (inputLine[0] == "Assemble!")
                {
                    break;
                }

                var part = inputLine[0];

                switch (part)
                {
                    case "Head":
                        Head currentHead = new Head
                        {
                            Energy = int.Parse(inputLine[1]),
                            Iq = int.Parse(inputLine[2]),
                            SkinMaterial = inputLine[3]
                        };

                        robot.AddHead(currentHead);
                        break;
                    case "Torso":
                        Torso currentTorso = new Torso
                        {
                            Energy = int.Parse(inputLine[1]),
                            ProcessorSize = double.Parse(inputLine[2]),
                            HousingMaterial = inputLine[3]
                        };

                        robot.AddTorso(currentTorso);
                        break;
                    case "Arm":
                        Arm currentArm = new Arm
                        {
                            Energy = int.Parse(inputLine[1]),
                            ReachDistance = int.Parse(inputLine[2]),
                            Fingers= int.Parse(inputLine[3])
                        };

                        robot.AddArm(currentArm);
                        break;
                    case "Leg":
                        Leg currentLeg = new Leg
                        {
                            Energy=int.Parse(inputLine[1]),
                            Strength=int.Parse(inputLine[2]),
                            Speed= int.Parse(inputLine[3])                            
                        };

                        robot.AddLeg(currentLeg);
                        break;
                }
                
                inputLine = Console.ReadLine().Split();
            }

            Console.WriteLine(robot.ToString());
        }
    }
}
