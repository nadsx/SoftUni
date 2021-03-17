using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_RawData
{
	public class StartUp
	{
		public static void Main()
		{
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                Queue<string> carInfo = new Queue<string>(Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries));

                string model = carInfo.Dequeue();
                int engineSpeed = int.Parse(carInfo.Dequeue());
                int enginePower = int.Parse(carInfo.Dequeue());
                int cargoWeight = int.Parse(carInfo.Dequeue());
                string cargoType = carInfo.Dequeue();

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                List<Tire> tires = new List<Tire>();

                while (carInfo.Any())
                {
                    double tirePressure = double.Parse(carInfo.Dequeue());
                    int tireYear = int.Parse(carInfo.Dequeue());
                    Tire tire = new Tire(tirePressure, tireYear);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Tire.Any(y => y.TirePressure < 1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == command && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
	}
}
