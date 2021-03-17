using System;

namespace P01ConvertMetersToKilometers
{
	class Program
	{
		static void Main(string[] args)
		{
			double meters = double.Parse(Console.ReadLine());

			Console.WriteLine($"{meters / 1000:f2}");

		}
	}
}
