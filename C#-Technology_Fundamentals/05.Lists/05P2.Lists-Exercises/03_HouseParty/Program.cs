using System;
using System.Collections.Generic;

namespace _03_HouseParty
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCommands = int.Parse(Console.ReadLine());
			var guests = new List<string>();

			for (int i = 0; i < numberOfCommands; i++)
			{
				string[] tokens = Console.ReadLine().Split();
				string name = tokens[0];

				if (tokens.Length == 3)
				{
					if (!guests.Contains(name))
					{
						guests.Add(name);
					}
					else
					{
						Console.WriteLine($"{name} is already in the list!");
					}
				}
				else if (tokens.Length == 4)
				{
					if (guests.Contains(name))
					{
						guests.Remove(name);
					}
					else
					{
						Console.WriteLine($"{name} is not in the list!");
					}
				}
			}

			foreach (var person in guests)
			{
				Console.WriteLine(person);
			}
		}
	}
}
