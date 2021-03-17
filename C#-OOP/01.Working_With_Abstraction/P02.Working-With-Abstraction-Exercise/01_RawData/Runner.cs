using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Runner
    {
        public void Run()
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                var engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                var cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();

                for (int j = 5; j <= 12; j += 2)
                {
                    double pressure = double.Parse(parameters[j]);
                    int age = int.Parse(parameters[j + 1]);

                    Tire tire = new Tire(age, pressure);
                    tires.Add(tire);
                }

                cars.Add(new Car(model, engine, cargo, tires));
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
                    .Select(c => c.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
