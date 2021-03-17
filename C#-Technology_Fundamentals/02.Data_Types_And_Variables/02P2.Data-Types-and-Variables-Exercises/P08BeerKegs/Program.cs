using System;

namespace P08BeerKegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfKegs = int.Parse(Console.ReadLine());

			string biggestKegModel = string.Empty;
			double biggestVolume = 0;

			for (int i = 0; i < numberOfKegs; i++)
			{
				string model = Console.ReadLine();
				double radius = double.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());

				double singleKegVolume = Math.PI * Math.Pow(radius, 2) * height;

				if(singleKegVolume > biggestVolume)
				{
					biggestVolume = singleKegVolume;
					biggestKegModel = model;
				}
			}

			Console.WriteLine(biggestKegModel);
		}
	}
}
