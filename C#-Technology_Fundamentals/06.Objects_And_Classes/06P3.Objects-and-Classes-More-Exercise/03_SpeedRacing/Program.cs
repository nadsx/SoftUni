using System;
using System.Collections.Generic;

namespace _03_SpeedRacing
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

				Car newCar = new Car(carInfo);
				cars.Add(newCar);
			}

			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] commands = input.Split();
				string currentModel = commands[1];

				cars.Find(x => x.Model == currentModel).CarCanMoveOrNot(double.Parse(commands[2]));

				input = Console.ReadLine();
			}

			cars.ForEach(Console.WriteLine);
		}
	}
	class Car
	{
		public string Model { get; set; }
		public double FuelAmount { get; set; }
		public double FuelConsumptionPerKm { get; set; }
		public double TraveledDistance { get; set; }

		public Car(string[] carInfo)
		{
			Model = carInfo[0];
			FuelAmount = int.Parse(carInfo[1]);
			FuelConsumptionPerKm = double.Parse(carInfo[2]);
		}

		public void CarCanMoveOrNot(double distance)
		{
			double neededFuel = FuelConsumptionPerKm * distance;

			if (FuelAmount >= neededFuel)
			{
				TraveledDistance += distance;
				FuelAmount -= neededFuel;
			}
			else
			{
				Console.WriteLine($"Insufficient fuel for the drive");
			}
		}

		public override string ToString()
		{
			return $"{Model} {FuelAmount:f2} {TraveledDistance}";
		}
	}
}
	

