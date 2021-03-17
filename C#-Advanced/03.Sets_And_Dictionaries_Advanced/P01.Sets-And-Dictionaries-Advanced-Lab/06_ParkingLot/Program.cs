using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ParkingLot
{
	class Program
	{
		static void Main(string[] args)
		{
			var carNumbers = new HashSet<string>();

			while (true)
			{
				string[] input = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray(); ;

				if (input[0] == "END")
				{
					break;
				}

				if (input[0] == "IN")
				{
					carNumbers.Add(input[1]);
				}
				else
				{
					carNumbers.Remove(input[1]);
				}
			}

			if (carNumbers.Count == 0)
			{
				Console.WriteLine($"Parking Lot is Empty");
			}
			else
			{
				foreach (var number in carNumbers)
				{
					Console.WriteLine(number);
				}
			}
		}
	}
}
