using System;

namespace P04SumOfChars
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfChars = int.Parse(Console.ReadLine());

			int sumOfChars = 0;

			for (int i = 0; i < numberOfChars; i++)
			{
				char letter = char.Parse(Console.ReadLine());

				sumOfChars += letter;
			}

			Console.WriteLine($"The sum equals: {sumOfChars}");

		}
	}
}
