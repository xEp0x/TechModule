using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03._1.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split();
            var skip = int.Parse(nums[0]);
            var take = int.Parse(nums[1]);
            var pattern = @"(\|<\w+)";
            var inputLine = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection cameraMatches = regex.Matches(inputLine);

            List<string> matchedCamera = new List<string>();

            foreach (Match camera in cameraMatches) 
            {
                var cameraStr = camera.Value.ToList();
                cameraStr = cameraStr.Skip(skip + 2).Take(take).ToList();
                matchedCamera.Add(string.Join("", cameraStr));
            }

            Console.WriteLine(string.Join(", ", matchedCamera));
        }
    }
}
