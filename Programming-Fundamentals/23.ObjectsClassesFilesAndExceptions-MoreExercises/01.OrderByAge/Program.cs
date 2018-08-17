using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (inputLine != "End")
            {
                var inputData = inputLine.Split();
                var currenetName = inputData[0];
                var currentId = inputData[1];
                var currentAge = int.Parse(inputData[2]);

                Person currentPerson = new Person(currenetName, currentId, currentAge);

                people.Add(currentPerson);
                inputLine = Console.ReadLine();
            }

            //var test = people.OrderBy(p => p.Age).ToList();

            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
