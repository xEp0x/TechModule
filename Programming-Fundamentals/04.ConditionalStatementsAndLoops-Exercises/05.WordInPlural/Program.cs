using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower();
            var outputWord = "";
            
            bool isY = word.EndsWith("y");
            bool endsInPeriod = word.EndsWith("o") ||  word.EndsWith("s") || word.EndsWith("x")
                || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh");
            
            if (isY)
            {
                outputWord = word.Remove(word.Length - 1);
                outputWord += "ies";
            }
            else
            {   
                if (endsInPeriod)
                {                    
                    outputWord += word + "es";
                }
                else
                {
                    outputWord = word + "s";
                }
                                              
            }

            Console.WriteLine(outputWord);
        }
    }
}
