using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_RawData
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCars = int.Parse(Console.ReadLine());
			List<Car> cars = new List<Car>();

			for (int i = 0; i < numberOfCars; i++)
			{
				string[] carInfo = Console.ReadLine().Split();
				string model = carInfo[0];

				Engine newEngine = new Engine()
				{
					EngineSpeed = int.Parse(carInfo[1]),
					EnginePower = int.Parse(carInfo[2])
				};

				Cargo newCargo = new Cargo()
				{
					CargoWeight = int.Parse(carInfo[3]),
					CargoType = carInfo[4]
				};

				Car newCar = new Car(model, newEngine, newCargo);
				cars.Add(newCar);
			}

			string command = Console.ReadLine();

			if (command == "fragile")
			{
				cars = cars.Where(x => x.CarCargo.CargoType == "fragile" && x.CarCargo.CargoWeight < 1000).ToList();
			}
			else if (command == "flamable")
			{
				cars = cars.Where(x => x.CarCargo.CargoType == "flamable" && x.CarEngine.EnginePower > 250).ToList();
			}

			cars.ForEach(Console.WriteLine);
		}
	}
	class Car
	{
		public string CarModel { get; set; }
		public Engine CarEngine { get; set; }
		public Cargo CarCargo { get; set; }

		public Car(string model, Engine engine, Cargo cargo)
		{
			CarModel = model;
			CarEngine = engine;
			CarCargo = cargo;
		}

		public override string ToString()
		{
			return $"{CarModel}";
		}
	}
	class Engine
	{
		public int EngineSpeed { get; set; }
		public int EnginePower { get; set; }
	}
	class Cargo
	{
		public int CargoWeight { get; set; }
		public string CargoType { get; set; }
	}
}
	

