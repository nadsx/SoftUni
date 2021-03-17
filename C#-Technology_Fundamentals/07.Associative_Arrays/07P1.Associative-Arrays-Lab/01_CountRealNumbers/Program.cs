using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

			var counts = new SortedDictionary<double, int>();

			foreach (var number in numbers)
			{
				if (!counts.ContainsKey(number))
				{
					counts.Add(number, 1);
				}
				else
				{
					counts[number]++;
				}
			}

			foreach (var kvp in counts)
			{
				Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
			}
		}
	}
}
