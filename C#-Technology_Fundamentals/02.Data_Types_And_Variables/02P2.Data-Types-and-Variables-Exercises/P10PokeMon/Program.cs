using System;

namespace P10PokeMon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePowerN = int.Parse(Console.ReadLine());
			int distanceM = int.Parse(Console.ReadLine());
			int exhaustionY = int.Parse(Console.ReadLine());

			int discountedPokePower = pokePowerN;
			int targets = 0;

			while(discountedPokePower >= distanceM)
			{
				discountedPokePower -= distanceM;
				targets++;

				if(discountedPokePower == pokePowerN * 0.5 && exhaustionY > 0)
				{
					discountedPokePower /= exhaustionY;
				}
			}
			Console.WriteLine(discountedPokePower);
			Console.WriteLine(targets);
		}
	}
}
