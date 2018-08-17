using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var hexNums = Console.ReadLine().Split().ToList();
            var validHexNums = hexNums.Where(num => num.Length == 2).ToList();

            for (int i = 0; i < validHexNums.Count; i++)
            {
                var tempNum = validHexNums[i].ToCharArray();
                Array.Reverse(tempNum);
                var str = new string(tempNum);
                validHexNums[i] = str;
            }

            var characters = ConvertToASCIISymbol(validHexNums);
            characters.Reverse();

            Console.WriteLine(string.Join("", characters));
        }

        static List<char> ConvertToASCIISymbol(List<string> validHexNums)
        {
            var characters = new List<char>();

            foreach (var hexNum in validHexNums)
            {
                var character = Convert.ToByte(hexNum, 16);
                characters.Add((char)character);
            }

            return characters;
        }
    }
}
