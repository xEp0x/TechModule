using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MorseCodeUpgraded
{
    class MorseCodeUpgraded
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split('|').ToList();
            StringBuilder sb = new StringBuilder();

            foreach (var codedLetter in inputLine)
            {
                var sum = 0;
                var zeroCount = codedLetter.Count(z => z == '0');
                var oneCount = codedLetter.Count(o => o == '1');                
                sum = zeroCount * 3 + oneCount * 5;

                var count = 1;
                for (int i = 0; i < codedLetter.Length - 1; i++)
                {
                    var previousCh = codedLetter[i];
                    var nextCh = codedLetter[i + 1];

                    if (previousCh == nextCh)
                    {
                        count++;
                    }
                    else
                    {
                        if (count == 1)
                        {
                            continue;
                        }
                        else
                        {
                            sum += count;
                            count = 1;
                        }
                    }
                }

                if (count != 1)
                {
                    sum += count;
                }

                sb.Append((char)sum);
            }

            Console.WriteLine(sb.Length == 0 ? "" : sb.ToString());
        }
    }
}
