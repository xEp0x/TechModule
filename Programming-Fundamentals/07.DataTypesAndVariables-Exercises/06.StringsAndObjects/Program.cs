﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloString = "Hello";
            string worldString = "World";

            object helloWorld = helloString + " " + worldString;

            string outputString = helloWorld.ToString();
            
            Console.WriteLine(outputString);

        }
    }
}
