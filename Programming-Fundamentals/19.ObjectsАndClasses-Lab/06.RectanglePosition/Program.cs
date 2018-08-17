using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectangleData = Console.ReadLine().Split().Select(double.Parse).ToList();
            var secondRectangleData = Console.ReadLine().Split().Select(double.Parse).ToList();

            Rectangle firstRectangle = new Rectangle
            {
                Left = firstRectangleData[0],
                Top = firstRectangleData[1],
                Width = firstRectangleData[2],
                Height = firstRectangleData[3]
            };

            Rectangle secondRectangle = new Rectangle
            {
                Left = secondRectangleData[0],
                Top = secondRectangleData[1],
                Width = secondRectangleData[2],
                Height = secondRectangleData[3]
            };

            bool isFirstLeftIn = firstRectangle.Left >= secondRectangle.Left;
            bool isFirstTopIn = firstRectangle.Top >= secondRectangle.Top;
            bool isFirstRightIn = firstRectangle.Right <= secondRectangle.Right;
            bool isFirstBottomIn = firstRectangle.Bottom <= secondRectangle.Bottom;

            bool isFirstInsideSecond = isFirstLeftIn && isFirstTopIn && isFirstRightIn && isFirstBottomIn;

            Console.WriteLine((isFirstInsideSecond) ? "Inside" : "Not Inside");
        }
    }
}
