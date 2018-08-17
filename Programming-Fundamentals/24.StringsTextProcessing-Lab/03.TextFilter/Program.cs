using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();            

            //wsiaka zabranena duma se podmenq sys string ot * s dalgina zabranenata duma
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length)); 
            }

            Console.WriteLine(text);
        }
    }
}
