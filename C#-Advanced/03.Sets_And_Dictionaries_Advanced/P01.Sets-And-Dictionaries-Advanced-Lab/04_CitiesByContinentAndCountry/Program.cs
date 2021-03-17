using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_CitiesByContinentAndCountry
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var dict = new Dictionary<string, Dictionary<string, List<string>>>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string continent = input[0];
				string country = input[1];
				string city = input[2];

				if (!dict.ContainsKey(continent))
				{
					dict[continent] = new Dictionary<string, List<string>>();
				}

				if (!dict[continent].ContainsKey(country))
				{
					dict[continent].Add(country, new List<string>());
				}

				dict[continent][country].Add(city);
			}

			foreach(var continent in dict)
			{
				Console.WriteLine($"{continent.Key}:");

				foreach(var valuePair in continent.Value)
				{
					Console.WriteLine($"{valuePair.Key} -> {string.Join(", ", valuePair.Value)}");
				}
			}
		}
	}
}
