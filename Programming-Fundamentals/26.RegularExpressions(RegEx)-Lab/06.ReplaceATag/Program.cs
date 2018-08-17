using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var pattern = @"<a.*href.*?=.*?(""|')(.*?)\1>(.*?)<\/a>";           
            var inputLine = Console.ReadLine();
            var regex = new Regex(pattern);

            while (true)
            {
                if(inputLine == "end")
                {
                    return;
                }

                var result = regex.Replace(inputLine, @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);
                inputLine = Console.ReadLine();
            }
        }
    }
}
