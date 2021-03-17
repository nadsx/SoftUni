using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_SoftUniParking
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCommands = int.Parse(Console.ReadLine());

			var registredUsersAndPlates = new Dictionary<string, string>();

			for (int i = 0; i < numberOfCommands; i++)
			{
				string[] tokens = Console.ReadLine().Split().ToArray();
				string user = tokens[1];

				if (tokens[0] == "register")
				{
					string plate = tokens[2];

					if (registredUsersAndPlates.ContainsKey(user))
					{
						Console.WriteLine($"ERROR: already registered with plate number {plate}");
					}
					else
					{
						registredUsersAndPlates[user] = plate;
						Console.WriteLine($"{user} registered {plate} successfully");
					}
				}
				else if (tokens[0] == "unregister")
				{
					if (!registredUsersAndPlates.ContainsKey(user))
					{
						Console.WriteLine($"ERROR: user {user} not found");
						continue;
					}
			
					registredUsersAndPlates.Remove(user);
					Console.WriteLine($"{user} unregistered successfully");									
				}
			}

			foreach (var user in registredUsersAndPlates)
			{
				Console.WriteLine($"{user.Key} => {user.Value}");
			}
		}
	}
}
