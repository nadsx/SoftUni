using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_EvenTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var numbers = new Dictionary<int, int>();

			for (int i = 0; i < n; i++)
			{
				int number = int.Parse(Console.ReadLine());

				if (!numbers.ContainsKey(number))
				{
					numbers.Add(number, 0);
				}

				numbers[number]++;
			}

			int evenNumberOfTimes = numbers
				.SingleOrDefault(number => number.Value % 2 == 0)
				.Key;

			Console.WriteLine(evenNumberOfTimes);
		}
	}
}
