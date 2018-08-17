using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var picturesCount = int.Parse(Console.ReadLine());
            var singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var singleFilteredPictureUploadTimeSeconds = int.Parse(Console.ReadLine());

            var allPictureFilterTimeSeconds = (long)picturesCount * singlePictureFilterTimeSeconds;
            var allPictureForUpload = (long)Math.Ceiling(picturesCount * filterFactor / 100d);
            var allFilteredPictureUploadTimeSeconds = allPictureForUpload * singleFilteredPictureUploadTimeSeconds;

            var timePictureToBeReadySeconds = allPictureFilterTimeSeconds + allFilteredPictureUploadTimeSeconds;

         //Console.WriteLine();
         //Console.WriteLine(picturesCount);
         //Console.WriteLine(singlePictureFilterTimeSeconds);
         //Console.WriteLine(filterFactor);
         //Console.WriteLine(singleFilteredPictureUploadTimeSeconds);
         //
         //Console.WriteLine();
         //Console.WriteLine(allPictureFilterTimeSeconds);
         //Console.WriteLine(allPictureForUpload);
         //Console.WriteLine(allFilteredPictureUploadTimeSeconds);
         //Console.WriteLine(timePictureToBeReadySeconds);

            var time = TimeSpan.FromSeconds(timePictureToBeReadySeconds);
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
            
            //t.ToString(@"d\d\,\ hh\:mm\:ss");

        }
    }

}
