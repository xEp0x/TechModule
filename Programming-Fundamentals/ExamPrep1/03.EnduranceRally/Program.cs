using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var delimiter = new char[] { ' ' };
            var drivers = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();
            var trackZone = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var checkPoints = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            foreach (var driver in drivers)
            {
                var fuel = (double)driver[0];
                var reachedPoint = 0;

                for (int i = 0; i < trackZone.Count; i++)
                {
                    if (checkPoints.Contains(i))
                    {
                        fuel += trackZone[i];
                    }
                    else
                    {
                        fuel -= trackZone[i];
                    }

                    if (fuel <= 0)
                    {
                        reachedPoint = i;
                        break;
                    }
                }

                Console.WriteLine(fuel > 0 ? $"{driver} - fuel left {fuel:F2}" : $"{driver} - reached {reachedPoint}");
            }
        }
    }
}
