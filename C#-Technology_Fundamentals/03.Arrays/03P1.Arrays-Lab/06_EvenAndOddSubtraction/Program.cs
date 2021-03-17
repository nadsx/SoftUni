using System;
using System.Linq;

namespace _06_EvenAndOddSubtraction
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int difference = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				int currentNumber = numbers[i];

				if (currentNumber % 2 == 0)
				{
					difference += currentNumber;
				}
				else
				{
					difference -= currentNumber;
				}

			}

			Console.WriteLine(difference);
		}
	}
}
