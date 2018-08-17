using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split();           

            var isExchangeable= CheckWordsIsMagicExchangeable(inputLine);

            if (isExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }

        static bool CheckWordsIsMagicExchangeable(string[] inputLine)
        {
            var firstStr = string.Empty;
            var secondStr = string.Empty;
            Dictionary<char, char> firstDict = new Dictionary<char, char>();
            List<char> diff = new List<char>();

            if (inputLine[0].Length <= inputLine[1].Length)
            {
                firstStr = inputLine[0];
                secondStr = inputLine[1];
                diff = secondStr.ToList().Skip(firstStr.Length).ToList();
            }
            else
            {
                firstStr = inputLine[1];
                secondStr = inputLine[0];
                diff = secondStr.ToList().Skip(firstStr.Length).ToList();
            }

            for (var i = 0; i < firstStr.Length; i++)
            {
                if (!firstDict.ContainsKey(firstStr[i]))
                {
                    if (firstDict.ContainsValue(secondStr[i]))
                    {
                        //Console.WriteLine("false");
                        return false;
                    }

                    firstDict.Add(firstStr[i], secondStr[i]);
                }
                else
                {
                    if (firstDict[firstStr[i]] == secondStr[i])
                    {
                        continue;
                    }
                    else
                    {
                        //Console.WriteLine("false");
                        return false;
                    }
                }
            }

            foreach (var ch in diff)
            {
                if (!firstDict.ContainsValue(ch))
                {
                    //Console.WriteLine("false");
                    return false;
                }
            }

            return true;
        }
    }
}
