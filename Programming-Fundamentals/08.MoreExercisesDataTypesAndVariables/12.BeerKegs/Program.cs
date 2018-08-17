using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegCount = int.Parse(Console.ReadLine());
            double maxKegVolume = 0.0;
            string maxKegVolumeModel = string.Empty;

            for (int i = 0; i < kegCount; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radiusOfKeg = double.Parse(Console.ReadLine());
                int heightKOfKeg = int.Parse(Console.ReadLine());
                double volumeOfKeg = Math.PI * radiusOfKeg * radiusOfKeg * heightKOfKeg;

                if (volumeOfKeg > maxKegVolume)
                {
                    maxKegVolume = volumeOfKeg;
                    maxKegVolumeModel = modelOfKeg;
                }
            }

            Console.WriteLine(maxKegVolumeModel);
        }
    }
}
