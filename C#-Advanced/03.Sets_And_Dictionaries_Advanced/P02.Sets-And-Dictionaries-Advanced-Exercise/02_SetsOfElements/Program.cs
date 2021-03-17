using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsOfElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] lengthOfSets = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			int n = lengthOfSets[0];
			int m = lengthOfSets[1];

			var firstSet = new HashSet<int>();
			var secondSet = new HashSet<int>();

			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());
				firstSet.Add(number);
			}

			for (int i = 0; i < m; i++)
			{
				int number = int.Parse(Console.ReadLine());
				secondSet.Add(number);
			}

			firstSet.IntersectWith(secondSet);

			Console.WriteLine(string.Join(" ", firstSet));
		}
	}
}
