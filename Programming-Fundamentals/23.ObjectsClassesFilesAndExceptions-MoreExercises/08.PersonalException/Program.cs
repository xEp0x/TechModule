using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PersonalException
{
    class PersonalException
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        throw new NegativeNumberException();
                    }
                    Console.WriteLine(num);
                }
            }
            catch (NegativeNumberException e)
            {                
                Console.WriteLine(e.Message);               
            }

        }
    }
}
