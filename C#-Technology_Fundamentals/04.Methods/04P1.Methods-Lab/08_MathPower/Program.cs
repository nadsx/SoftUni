using System;

namespace _08_MathPower
{
	class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			double power = double.Parse(Console.ReadLine());

			double result = GetNumberRaisedToAPower(number, power);

			Console.WriteLine(result);
		}

		private static double GetNumberRaisedToAPower(double number, double power)
		{
			double result = number;

			for (int i = 1; i < power; i++)
			{
				result *= number;
			}

			return result;
		}
	}
}