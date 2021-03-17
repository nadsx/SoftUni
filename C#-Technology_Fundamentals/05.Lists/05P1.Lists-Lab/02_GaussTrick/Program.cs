using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_GaussTrick
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> result = new List<int>();

			for (int i = 0; i < numbers.Count / 2; i++) 
			{
				var first = numbers[i];
				var last = numbers[numbers.Count - 1 - i];

				var resultNumber = first + last;

				result.Add(resultNumber);
			}

			if (numbers.Count % 2 == 1)
			{
				var middle = numbers[numbers.Count / 2];
				result.Add(middle);
			}

			Console.WriteLine(string.Join(" ", result));
		}
	}
}
