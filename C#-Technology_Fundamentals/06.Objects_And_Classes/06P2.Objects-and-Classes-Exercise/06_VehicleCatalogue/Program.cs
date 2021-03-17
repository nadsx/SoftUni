using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_VehicleCatalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicleCatalogue = new List<Vehicle>();

			GetVehicles(vehicleCatalogue);
			PrintVehicles(vehicleCatalogue);

			PrintAverageHorsepower(vehicleCatalogue, true);
			PrintAverageHorsepower(vehicleCatalogue, false);
		}

		private static void PrintAverageHorsepower(List<Vehicle> vehicleCatalogue, bool isCar)
		{
			List<Vehicle> horsepowerList = vehicleCatalogue.Where(type => type.IsCar == isCar).ToList();

			double averageHorsepower = horsepowerList.Count == 0 ?
				0.0 : horsepowerList.Select(v => (double)v.Horsepower).Average();

			string vehicleType = isCar ? "Cars" : "Trucks";

			Console.WriteLine($"{vehicleType} have average horsepower of: {averageHorsepower:f2}.");
		}

		private static void PrintVehicles(List<Vehicle> vehicleCatalogue)
		{
			string model = Console.ReadLine();

			while (model != "Close the Catalogue")
			{
				Console.WriteLine(vehicleCatalogue.First(v => v.Model == model));

				model = Console.ReadLine();
			}
		}

		private static void GetVehicles(List<Vehicle> vehicleCatalogue)
		{
			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] vehicleInfo = input.Split();
				bool typeOfVehicle = vehicleInfo[0] == "car";
				string model = vehicleInfo[1];
				string color = vehicleInfo[2];
				int horsepower = int.Parse(vehicleInfo[3]);

				var newVehicle = new Vehicle()
				{
					IsCar = typeOfVehicle,
					Model = model,
					Color = color,
					Horsepower = horsepower
				};

				vehicleCatalogue.Add(newVehicle);

				input = Console.ReadLine();
			}
		}
	}
	class Vehicle
	{
		public bool IsCar { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Horsepower { get; set; }

		public override string ToString()
		{
			string vehicleType = IsCar ? "Car" : "Truck";

			string output = $"Type: {vehicleType}\r\n";
			output += $"Model: {Model}\r\n";
			output += $"Color: {Color}\r\n";
			output += $"Horsepower: {Horsepower}";
			return output;
		}
	}
}



