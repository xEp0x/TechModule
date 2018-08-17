using System;
using System.Linq;

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

        string[] command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();

        while (!command[0].Equals("stop"))
        {

            int[] args = new int[2];

            if (command[0].Equals("add") || 
                command[0].Equals("subtract") || 
                command[0].Equals("multiply"))
            {
                args[0] = int.Parse(command[1]);
                args[1] = int.Parse(command[2]);
                PerformAction(array, command[0], args);
            }
            else
            {
                PerformAction(array, command[0], args);
            }           

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
        }
    }

    static void PerformAction(long[] array, string action, int[] args)
    {
        
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
    }

    static void ArrayShiftRight(long[] array)
    {
        long lastMember = array[array.Length - 1];

        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastMember;
    }

    static void ArrayShiftLeft(long[] array)
    {
        long firstMemeber = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = firstMemeber;
    }

    static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}