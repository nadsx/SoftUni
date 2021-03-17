using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
			int capacityOfWagon = int.Parse(Console.ReadLine());

			string input = Console.ReadLine();

			while (input != "end")
			{
				List<string> tokens = input.Split().ToList();
				string command = tokens[0];

				if (command == "Add")
				{
					int numberOfPassengers = int.Parse(tokens[1]);

					wagons.Add(numberOfPassengers);
				}
				else
				{
					int passengersToFit = int.Parse(tokens[0]);

					for (int i = 0; i < wagons.Count; i++)
					{
						if (wagons[i] + passengersToFit <= capacityOfWagon)
						{
							wagons[i] += passengersToFit;
							break;
						}
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", wagons));
		}
	}	
}
