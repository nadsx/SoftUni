using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_VehicleCatalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Car> carsList = new List<Car>();
			List<Truck> trucksList = new List<Truck>();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split("/");
				string typeVehicle = tokens[0];

				if (typeVehicle == "Car")
				{
					var car = new Car()
					{
						Brand = tokens[1],
						Model = tokens[2],
						HorsePower = int.Parse(tokens[3])
					};

					carsList.Add(car);
				}
				else if (typeVehicle == "Truck")
				{
					var truck = new Truck()
					{
						Brand = tokens[1],
						Model = tokens[2],
						Weight = int.Parse(tokens[3])
					};

					trucksList.Add(truck);
				}

				input = Console.ReadLine();
			}

			var catalogVehicle = new CatalogVehicle()
			{
				Cars = carsList,
				Trucks = trucksList
			};

			if (catalogVehicle.Cars.Any())
			{
				Console.WriteLine("Cars:");

				foreach (var car in catalogVehicle.Cars.OrderBy(x => x.Brand))
				{
					Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
				}
			}

			if (catalogVehicle.Trucks.Any())
			{
				Console.WriteLine("Trucks:");

				foreach (var truck in catalogVehicle.Trucks.OrderBy(x => x.Brand))
				{
					Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
				}
			}

		}
	}
	class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int HorsePower { get; set; }
	}
	class Truck
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Weight { get; set; }
	}
	class CatalogVehicle
	{
		public List<Car> Cars { get; set; }
		public List<Truck> Trucks { get; set; }
	}
}
