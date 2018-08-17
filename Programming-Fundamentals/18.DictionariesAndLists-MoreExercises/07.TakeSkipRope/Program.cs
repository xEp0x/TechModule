using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToList();

            //var digits = inputString.Where(symbol => char.IsDigit(symbol)).ToList();
            var digits = inputString.Where(symbol => char.IsDigit(symbol)).Select(symbol => int.Parse(symbol.ToString())).ToList();

            var nonDigits = inputString.Where(symbol => !char.IsDigit(symbol)).ToList();

            var takeList = digits.Where((digit, index) => index % 2 == 0).ToList();
            var skipList = digits.Where((digit, index) => index % 2 == 1).ToList();

            var result = string.Empty;
            var totalSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                //var skip = skipList[i] - 48;
                //var take = takeList[i] - 48;
                var skip = skipList[i];
                var take = takeList[i];
                var currentResult = new string(nonDigits.Skip(totalSkip).Take(take).ToArray());
                result = string.Concat(result, currentResult);
                totalSkip += skip + take;
            }

            Console.WriteLine(result);
        }
    }
}
