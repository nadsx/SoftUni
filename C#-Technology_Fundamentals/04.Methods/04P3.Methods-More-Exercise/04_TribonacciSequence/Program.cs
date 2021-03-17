using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_TribonacciSequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var tribonacciSequence = new List<int>();
			tribonacciSequence.Add(1);

			for (int i = 0; i < n - 1; i++)
			{
				if (i < 3)
				{
					tribonacciSequence.Add(tribonacciSequence.Sum());
				}
				else
				{
					tribonacciSequence.Add(tribonacciSequence[i] + tribonacciSequence[i - 1] + tribonacciSequence[i - 2]);
				}
			}

			Console.WriteLine(string.Join(" ", tribonacciSequence));
		}
	}
}
