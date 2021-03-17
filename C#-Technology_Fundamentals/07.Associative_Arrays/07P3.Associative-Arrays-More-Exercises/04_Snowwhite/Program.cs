using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Snowwhite
{
	class Program
	{
		static void Main(string[] args)
		{
			var dwarfs = new Dictionary<string, Dictionary<string, int>>();

			string input = Console.ReadLine();

			while (input != "Once upon a time")
			{
				var dwarfInfo = input.Split(" <:> ").ToArray();
				string name = dwarfInfo[0];
				string color = dwarfInfo[1];
				int physics = int.Parse(dwarfInfo[2]);

				if (dwarfs.ContainsKey(color))
				{
					if (dwarfs[color].ContainsKey(name))
					{
						if (dwarfs[color][name] < physics)
						{
							dwarfs[color][name] = physics;
						}
					}
					else
					{
						dwarfs[color].Add(name, physics);
					}
				}
				else
				{
					dwarfs[color] = new Dictionary<string, int>();
					dwarfs[color].Add(name, physics);

				}

				input = Console.ReadLine();
			}

			var sortedDwarfs = new Dictionary<string, int>();

			foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value.Count()))
			{
				foreach (var valuePair in dwarf.Value)
				{
					sortedDwarfs.Add($"({dwarf.Key}) {valuePair.Key} <-> ", valuePair.Value);
				}
			}

			foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
			{
				Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
			}
		}
	}
}
