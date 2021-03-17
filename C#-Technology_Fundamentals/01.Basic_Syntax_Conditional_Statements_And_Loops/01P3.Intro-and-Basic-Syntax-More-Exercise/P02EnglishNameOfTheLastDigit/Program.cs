using System;
using System.Linq;

namespace P02EnglishNameOfTheLastDigit
{
	class Program
	{
		public static void Main()
		{

			long number = long.Parse(Console.ReadLine());

			number = GetLastDigit(number);

			string[] verbalNums =
			{
				"zero",
				"one",
				"two",
				"three",
				"four",
				"five",
				"six",
				"seven",
				"eight",
				"nine"
			};

			Console.WriteLine(verbalNums[number]);

		}

		private static long GetLastDigit(long number)
		{
			long lastDigit = long.Parse(number.ToString().Last().ToString());

			return lastDigit;
		}
	}
}
