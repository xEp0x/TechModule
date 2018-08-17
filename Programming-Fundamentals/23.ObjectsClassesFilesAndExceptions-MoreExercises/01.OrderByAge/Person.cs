using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OrderByAge
{
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }
}
