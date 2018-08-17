using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Problem_
{
    class Program
    {
        static void Main(string[] args)
        {
            var distances = Console.ReadLine().Split(new char[] { ' ' }).Select(long.Parse).ToList();
            var sumRemovedElements = 0L;

            while (distances.Count != 0)
            {
                var index = int.Parse(Console.ReadLine());
                var removedElement = 0L;

                if (index < 0)
                {
                    removedElement = distances.First();
                    var lastElement = distances.Last();
                    distances.RemoveAt(0);
                    distances.Insert(0, lastElement);

                }
                else if (index > distances.Count - 1)
                {
                    removedElement = distances.Last();
                    var firstElement = distances.First();
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(firstElement);
                }
                else
                {
                    removedElement = distances[index];
                    distances.RemoveAt(index);
                }

                sumRemovedElements += removedElement;

                for (int i = 0; i < distances.Count; i++)
                {
                    var currentDistance = distances[i];

                    if (currentDistance <= removedElement)
                    {
                        distances[i] += removedElement;
                    }
                    else
                    {
                        distances[i] -= removedElement;
                    }
                }
            }

            Console.WriteLine(sumRemovedElements);
        }
    }
}
