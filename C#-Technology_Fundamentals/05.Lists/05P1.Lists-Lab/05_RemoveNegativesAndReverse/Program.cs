using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndReverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> positiveNumbers = new List<int>();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] >= 0)
				{
					positiveNumbers.Add(numbers[i]);
				}
				//Another way:
				//if (numbers[i] < 0)
				//{
				//	numbers.RemoveAt(i);
				//	i--;
				//}
			}

			if (positiveNumbers.Count > 0)
			{
				positiveNumbers.Reverse();
				Console.WriteLine(string.Join(" ", positiveNumbers));
			}
			else
			{
				Console.WriteLine("empty");
			}
		}
	}
}
