using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            inputLine = EnterVehicleInfo(inputLine, cars, trucks);

            PrintModelInfo(cars, trucks);

            var carsAverageHorsePower = 0.0;
            var trucksAverageHorsePower = 0.0;

            if (cars.Count > 0)
            {
                carsAverageHorsePower = cars.Select(c => c.HorsePower).Average(hp => hp);
            }
             
            if (trucks.Count > 0)
            {
                trucksAverageHorsePower = trucks.Select(t => t.HorsePower).Average(hp => hp);
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:F2}.");
        }



        static void PrintModelInfo(List<Car> cars, List<Truck> trucks)
        {
            var inputModel = Console.ReadLine();

            while (inputModel != "Close the Catalogue")
            {
                var model = inputModel;
                var itemCar = cars.FirstOrDefault(c => c.Model == model);

                if (itemCar != null)
                {
                    Console.WriteLine($"Type: Car");
                    Console.WriteLine($"Model: {itemCar.Model}");
                    Console.WriteLine($"Color: {itemCar.Color}");
                    Console.WriteLine($"Horsepower: {itemCar.HorsePower}");
                }
                else
                {
                    var itemTruck = trucks.FirstOrDefault(c => c.Model == model);

                    if (itemTruck != null)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {itemTruck.Model}");
                        Console.WriteLine($"Color: {itemTruck.Color}");
                        Console.WriteLine($"Horsepower: {itemTruck.HorsePower}");
                    }
                    else
                    {
                        Console.WriteLine("No such model vihicle!");
                    }
                }

                inputModel = Console.ReadLine();
            }
        }

        static string EnterVehicleInfo(string inputLine, List<Car> cars, List<Truck> trucks)
        {
            while (inputLine != "End")
            {
                var inputData = inputLine.Split().ToList();
                var type = inputData.First().ToLower();
                var model = inputData[1];
                var color = inputData[2];
                var horsePower = int.Parse(inputData.Last());

                if (type == "car")
                {
                    Car currentCar = new Car(model, color, horsePower);
                    cars.Add(currentCar);
                }
                else if (type == "truck")
                {
                    Truck currentTruck = new Truck(model, color, horsePower);
                    trucks.Add(currentTruck);
                }
                else
                {
                    Console.WriteLine("No such vehicle!");
                }

                inputLine = Console.ReadLine();
            }

            return inputLine;
        }
    }    
}

