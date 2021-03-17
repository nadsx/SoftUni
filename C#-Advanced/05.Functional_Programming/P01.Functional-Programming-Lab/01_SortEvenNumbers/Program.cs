using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SortEvenNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			// (Example for "Functional Programming")

			List<int> numbers = Console.ReadLine()
				.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(Parse)
				.Where(Filter)
				.OrderBy(Sort)
				.ToList();

			Console.WriteLine(string.Join(", ", numbers));
		}

		public static int Sort(int number)
		{
			return number;
		}

		public static bool Filter(int number)
		{
			return number % 2 == 0;
		}

		public static int Parse(string input)
		{
			return int.Parse(input);
		}
	}
}
