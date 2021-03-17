using System;

namespace P02SumDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int lastDigit = 0;
			int sumOfDigits = 0;

			while(number != 0)
			{
				lastDigit = number % 10;
				number /= 10;
				sumOfDigits += lastDigit;
			}

			Console.WriteLine(sumOfDigits);
		}
	}
}
