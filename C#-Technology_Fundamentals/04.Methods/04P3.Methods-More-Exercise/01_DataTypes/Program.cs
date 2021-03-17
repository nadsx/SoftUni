using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			string dataType = Console.ReadLine();

			switch (dataType)
			{
				case "int":
					int number = int.Parse(Console.ReadLine());
					Console.WriteLine(GetResult(number));
					break;
				case "real":
					double realNumber = double.Parse(Console.ReadLine());
					Console.WriteLine($"{GetResult(realNumber):f2}");
					break;
				case "string":
					string stringText = Console.ReadLine();
					Console.WriteLine(GetResult(stringText));
					break;
			}
		}

		private static int GetResult(int number)
		{
			return number * 2;
		}

		private static double GetResult(double realNumber)
		{
			return realNumber * 1.5;
		}

		private static string GetResult(string stringText)
		{
			return $"${stringText}$";
		}
	}
}
