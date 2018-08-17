using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEatosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitPrime = int.Parse(Console.ReadLine());
            bool[] sieve = new bool[limitPrime + 1];

            for (int i = 2; i <= limitPrime; i++)
            {
                sieve[i] = true;
            }

            for (int i = 2; i <= limitPrime; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * 2; j <= limitPrime; j += i)
                    {
                        sieve[j] = false;
                    }
                }
            }

            for (int i = 0; i <= limitPrime; i++)
            {
                if (sieve[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
