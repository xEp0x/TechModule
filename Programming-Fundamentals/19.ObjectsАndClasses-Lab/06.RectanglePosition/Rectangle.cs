using System;

namespace _06.RectanglePosition
{
    public class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        // This is read-only property and it is equal to the below record. This is shorter way to represent below record. 
        public double Area => Height * Width;

        // This is read-only property and it is equal to the above record
        // public double Area
        // {
        //     get
        //     {
        //         return Height * Width;
        //     }
        // }

        public double Bottom => Top + Height;

        public double Right => Left + Width;
    }
}
