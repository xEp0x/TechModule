using System;
using System.Linq;
//using System.Numerics;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] action = command.Split(ArgumentsDelimiter);
            int[] args = new int[2];

            if (action.Length != 1)
            {
                args[0] = int.Parse(action[1]);
                args[1] = int.Parse(action[2]);
            }

            //array = 
                PerformAction(array, action[0], args);

            PrintArray(array);
            Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }

        //return array;
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastMember = array[array.Length - 1];

        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastMember;

        //return array;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long firstMemeber = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = firstMemeber;

        //return array;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}