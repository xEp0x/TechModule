using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int cources = 0;

            if (peopleNumber % elevatorCapacity == 0)
            {
                cources = peopleNumber / elevatorCapacity;
            }
            else
            {
                cources = peopleNumber / elevatorCapacity + 1;
            }

            Console.WriteLine(cources);

        }
    }
}
