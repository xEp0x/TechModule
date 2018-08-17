using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SentenceTheThief
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
            double yearsInPrison = 0.0;

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

                    if (sbyteMaxValue < 0)
                    {
                        yearsInPrison = Math.Ceiling(sbyteMaxValue / -128.0);
                    }
                    else
                    {
                        yearsInPrison = Math.Ceiling(sbyteMaxValue / 127.0);
                    }

                    if (yearsInPrison > 1)
                    {
                        Console.WriteLine($"Prisoner with id {sbyteMaxValue} is sentenced to {yearsInPrison} years");                        
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {sbyteMaxValue} is sentenced to {yearsInPrison} year");
                    }

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

                    if (intMaxValue < 0)
                    {
                        yearsInPrison = Math.Ceiling(intMaxValue / -128.0);
                    }
                    else
                    {
                        yearsInPrison = Math.Ceiling(intMaxValue / 127.0);
                    }

                    if (yearsInPrison > 1)
                    {                        
                        Console.WriteLine($"Prisoner with id {intMaxValue} is sentenced to {yearsInPrison} years");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {intMaxValue} is sentenced to {yearsInPrison} year");
                    }

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

                    if (longMaxValue < 0)
                    {
                        yearsInPrison = Math.Ceiling(longMaxValue / -128.0);
                    }
                    else
                    {
                        yearsInPrison = Math.Ceiling(longMaxValue / 127.0);
                    }

                    if (yearsInPrison > 1)
                    {                        
                        Console.WriteLine($"Prisoner with id {longMaxValue} is sentenced to {yearsInPrison} years");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {longMaxValue} is sentenced to {yearsInPrison} year");
                    }

                    break;
            }

        }
    }
}