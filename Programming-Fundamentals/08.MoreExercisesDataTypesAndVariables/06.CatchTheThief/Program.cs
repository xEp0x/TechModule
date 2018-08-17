using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {

            string thiefIdNumeralType = Console.ReadLine();
            int idCount = int.Parse(Console.ReadLine());
            sbyte sbyteMaxValue = sbyte.MinValue;
            int intMaxValue = int.MinValue;
            long longMaxValue = long.MinValue;

            switch (thiefIdNumeralType)
            {
                case "sbyte":
                    for (int i = 0; i < idCount; i++)
                    {
                        sbyte sbyteNumber = 0;                        
                        string idForCheck = Console.ReadLine();
                        bool isIdForCheckSbyte = sbyte.TryParse(idForCheck, out sbyteNumber);                        

                        if (isIdForCheckSbyte)
                        {
                            if (sbyteNumber > sbyteMaxValue)
                            {
                                sbyteMaxValue = sbyteNumber;
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                    Console.WriteLine(sbyteMaxValue);
                    break;

                case "int":
                    for (int i = 0; i < idCount; i++)
                    {                        
                        int intNumber = 0;
                        string idForCheck = Console.ReadLine();
                        bool isIdForCheckInt = int.TryParse(idForCheck, out intNumber);

                        if (isIdForCheckInt)
                        {
                            if (intNumber > intMaxValue)
                            {
                                intMaxValue = intNumber;
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                    Console.WriteLine(intMaxValue);
                    break;

                case "long":
                    for (int i = 0; i < idCount; i++)
                    {
                        long longNumber = 0;
                        string idForCheck = Console.ReadLine();
                        bool isIdForCheckLong = long.TryParse(idForCheck, out longNumber);

                        if (isIdForCheckLong)
                        {
                            if (longNumber > longMaxValue)
                            {
                                longMaxValue = longNumber;
                            }
                        }
                        else
                        {
                            continue;
                        }

                    }
                    Console.WriteLine(longMaxValue);
                    break;
            }

        }
    }
}