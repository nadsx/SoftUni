using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_AutoRepairAndService
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] carModels = Console.ReadLine().Split().ToArray();
			Queue<string> cars = new Queue<string>(carModels);
			Stack<string> servedCars = new Stack<string>();

			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] commandTokens = input.Split("-").ToArray();
				string command = commandTokens[0];

				switch (command)
				{
					case "Service":
						if (cars.Count > 0)
						{
							string currentVehicle = cars.Dequeue();
							servedCars.Push(currentVehicle);
							Console.WriteLine($"Vehicle {currentVehicle} got served.");
						}
						break;
					case "CarInfo":
						string carModelName = commandTokens[1];

						string waitingOrServed = cars.Contains(carModelName) ?
							"Still waiting for service." : "Served.";

						Console.WriteLine(waitingOrServed);
						break;
					case "History":
						Console.WriteLine(string.Join(", ", servedCars));
						break;
				}

				input = Console.ReadLine();
			}

			if (cars.Count > 0)
			{
				Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
			}

			Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
		}
	}
}
