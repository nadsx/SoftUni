using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountSameValuesInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine()
				.Split()
				.Select(double.Parse)
				.ToArray();

			var counts = new Dictionary<double, int>();

			foreach (var number in numbers)
			{
				if (counts.ContainsKey(number))
				{
					counts[number]++;
				}
				else
				{
					counts[number] = 1;
				}
			}

			foreach (var number in counts)
			{
				Console.WriteLine($"{number.Key} - {number.Value} times");
			}
		}
	}
}
