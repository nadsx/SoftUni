using System;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int counter = 1;
			int longestSequence = 1;
			int number = 0;

			for (int i = 0; i < numbers.Length - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					counter++;

					if (counter > longestSequence)
					{
						longestSequence = counter;
						number = numbers[i];
					}
				}
				else
				{
					counter = 1;
				}
			}

			for (int i = 0; i < longestSequence; i++)
			{
				Console.Write(number + " ");
			}
		}
	}
}
