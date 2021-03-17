using System;

namespace _05_MultiplicationSign
{
	class Program
	{
		static void Main(string[] args)
		{
			double num1 = double.Parse(Console.ReadLine());
			double num2 = double.Parse(Console.ReadLine());
			double num3 = double.Parse(Console.ReadLine());

			if (num1 == 0 || num2 == 0 || num3 == 0)
			{
				Console.WriteLine("zero");
			}
			else
			{
				//5 * (-5) * (-4) = 100
				//5 * 5 * (-4) = -100

				if ((num1 > 0 && num2 > 0 && num3 > 0) ||
					(num1 > 0 && num2 < 0 && num3 < 0) ||
					(num1 < 0 && num2 > 0 && num3 < 0) ||
					(num1 < 0 && num2 < 0 && num3 > 0))
				{
					Console.WriteLine("positive");
				}
				else
				{
					Console.WriteLine("negative");
				}
			}
		}
	}
}
