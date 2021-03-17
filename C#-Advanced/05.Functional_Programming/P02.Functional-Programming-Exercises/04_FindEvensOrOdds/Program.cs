using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FindEvensOrOdds
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> bounds = Console.ReadLine()
				   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
				   .Select(int.Parse)
				   .ToList();

			int lowerBound = bounds[0];
			int upperBound = bounds[1];

			string condition = Console.ReadLine();
			List<int> listOfNumbers = new List<int>();
			Predicate<int> evenOrOdd;

			for (int i = lowerBound; i <= upperBound; i++)
			{
				listOfNumbers.Add(i);
			}

			if (condition == "even")
			{
				evenOrOdd = x => x % 2 == 0;
			}
			else
			{
				evenOrOdd = x => x % 2 != 0;
			}

			Console.Write(string.Join(" ", listOfNumbers.Where(x => evenOrOdd(x))) + " ");
		}
	}
}
