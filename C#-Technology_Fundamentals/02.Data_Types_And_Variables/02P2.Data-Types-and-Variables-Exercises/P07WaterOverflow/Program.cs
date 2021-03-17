using System;

namespace P07WaterOverflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int waterTank = 0;

			for (int i = 0; i < n; i++)
			{
				int quantitiesOfWater = int.Parse(Console.ReadLine());

				if(waterTank + quantitiesOfWater <= 255)
				{
					waterTank += quantitiesOfWater;
				}
				else
				{
					Console.WriteLine("Insufficient capacity!");
				}
			}

			Console.WriteLine(waterTank);
		}
	}
}
