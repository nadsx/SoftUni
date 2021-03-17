using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01_SignOfIntegerNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			PrintSign(number);
		}

		public static void PrintSign(int number)
		{
			if (number > 0)
			{
				Console.WriteLine($"The number {number} is positive.");
			}
			else if (number < 0)
			{
				Console.WriteLine($"The number {number} is negative.");
			}
			else
			{
				Console.WriteLine($"The number {number} is zero.");
			}
		}
	}
}
