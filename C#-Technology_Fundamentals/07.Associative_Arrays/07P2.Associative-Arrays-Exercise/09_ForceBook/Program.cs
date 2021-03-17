using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_ForceBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var forces = new Dictionary<string, List<string>>();

			string input = Console.ReadLine();

			while (input != "Lumpawaroo")
			{
				var command = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
				string currentSide = string.Empty;
				string currentUser = string.Empty;

				if (input.Contains("|"))
				{
					currentSide = command[0];
					currentUser = command[1];

					if (!forces.ContainsKey(currentSide))
					{
						forces[currentSide] = new List<string>();
					}

					bool isContains = forces.Any(x => x.Value.Contains(currentUser));

					if (!forces[currentSide].Contains(currentUser) && isContains == false)
					{
						forces[currentSide].Add(currentUser);
					}
				}
				else if (input.Contains("->"))
				{
					currentUser = command[0];
					currentSide = command[1];

					foreach (var force in forces)
					{
						if (force.Value.Contains(currentUser))
						{
							force.Value.Remove(currentUser);
							break;
						}
					}

					if (!forces.ContainsKey(currentSide))
					{
						forces[currentSide] = new List<string>();
					}

					if (!forces[currentSide].Contains(currentUser))
					{
						forces[currentSide].Add(currentUser);
					}

					Console.WriteLine($"{currentUser} joins the {currentSide} side!");
				}

				input = Console.ReadLine();
			}

			var sortedForces = forces
				.OrderByDescending(x => x.Value.Count)
				.ThenBy(x => x.Key)
				.ToDictionary(k => k.Key, v => v.Value);

			foreach (var force in sortedForces)
			{
				if (force.Value.Count == 0)
					continue;

				Console.WriteLine($"Side: {force.Key}, Members: {force.Value.Count}");

				Console.WriteLine(string.Join("\n", force.Value.Select(x => $"! {x}").OrderBy(x => x)));
			}
		}
	}
}