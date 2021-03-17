using System;

namespace P02PoundsToDollars
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal britishPounds = decimal.Parse(Console.ReadLine());

			Console.WriteLine($"{britishPounds * 1.31m:f3}");

		}
	}
}
