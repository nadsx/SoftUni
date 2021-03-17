using System;
using System.Numerics;

namespace P11Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfSnowballs = int.Parse(Console.ReadLine());

			int snowballSnow = 0;
			int snowballTime = 0;
			double snowballQuality = 0;
			BigInteger snowballValue = 0;

			for (int i = 0; i < numberOfSnowballs; i++)
			{
				int snow = int.Parse(Console.ReadLine());
				int time = int.Parse(Console.ReadLine());
				int quality = int.Parse(Console.ReadLine());

				//(snowballSnow / snowballTime) ^ snowballQuality
				BigInteger newSnowballValue = BigInteger.Pow((snow / time), quality);

				if(newSnowballValue >= snowballValue)
				{
					snowballValue = newSnowballValue;
					snowballSnow = snow;
					snowballTime = time;
					snowballQuality = quality;
				}
			}

			Console.WriteLine($"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})");
		}
	}
}
