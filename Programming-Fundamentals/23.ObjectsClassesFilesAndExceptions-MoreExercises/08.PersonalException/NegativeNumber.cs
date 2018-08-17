using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PersonalException
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("My first exception is awesome!!!")
        {

        }
    }
}
