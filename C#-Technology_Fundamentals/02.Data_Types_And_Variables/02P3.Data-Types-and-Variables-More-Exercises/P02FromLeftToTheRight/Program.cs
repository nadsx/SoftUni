using System;
using System.Linq;

namespace P02FromLeftToTheRight
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

				long leftNumber = numbers[0];
				long rightNumber = numbers[1];

				long biggerNumber = rightNumber; 

				if (leftNumber > rightNumber)   //  <===== АЛГОРИТЪМ !!!!!!!!!
				{
					biggerNumber = leftNumber;
				}

				long sumOfDigits = 0;

				while (biggerNumber != 0)
				{
					sumOfDigits += biggerNumber % 10;
					biggerNumber /= 10;
				}

				Console.WriteLine(Math.Abs(sumOfDigits));
			}

		}
	}
}
