using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
	class Program
	{
		static void Main(string[] args)
		{
			var resources = new Dictionary<string, int>();

			var resource = Console.ReadLine();

			while (resource != "stop")
			{
				var quantity = int.Parse(Console.ReadLine());

				if (!resources.ContainsKey(resource))
				{
					resources[resource] = 0;
				}

				resources[resource] += quantity;

				resource = Console.ReadLine();
			}

			foreach (var item in resources)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
		}
	}
}
