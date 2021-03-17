using System;

namespace _10_TopNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			for (int i = 17; i < number; i++)
			{
				if (CheckIfDevisableByEight(i) == true && CheckForOddDigit(i) == true)
				{
					Console.WriteLine(i);
				}
			}
		}

		public static bool CheckIfDevisableByEight(int number)
		{
			int sumOfDigits = 0;
			bool isDevisable = false;

			while (number != 0)
			{
				sumOfDigits += number % 10;
				number /= 10;

				if (number == 0 && sumOfDigits % 8 == 0)
				{
					isDevisable = true;
				}
			}

			return isDevisable;
		}

		public static bool CheckForOddDigit(int number)
		{
			bool isOddDigit = false;

			while (number != 0)
			{
				if ((number % 10) % 2 == 1)
				{
					isOddDigit = true;
				}
				number /= 10;
			}

			return isOddDigit;
		}
	}
}
