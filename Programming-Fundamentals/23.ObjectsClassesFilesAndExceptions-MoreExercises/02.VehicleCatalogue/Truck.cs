using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VehicleCatalogue
{
    public class Truck
    {
        public Truck (string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }
    }
}
