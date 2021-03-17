using System;
using System.Linq;

namespace _07_EqualArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int[] arrTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int sum = 0;

			for (int i = 0; i < arrOne.Length; i++)
			{
				if (arrOne[i] != arrTwo[i])
				{
					Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
					return;
				}

				sum += arrTwo[i];
			}

			Console.WriteLine($"Arrays are identical. Sum: {sum}");
		}
	}
}
