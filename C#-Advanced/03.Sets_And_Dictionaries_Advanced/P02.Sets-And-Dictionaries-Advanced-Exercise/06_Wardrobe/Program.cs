using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Wardrobe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var wardrobe = new Dictionary<string, Dictionary<string, int>>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine()
					.Split(new[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string color = input[0];

				if (!wardrobe.ContainsKey(color))
				{
					wardrobe.Add(color, new Dictionary<string, int>());
				}

				input = input.Skip(1).ToArray();

				foreach (var clothes in input)
				{
					if (!wardrobe[color].ContainsKey(clothes))
					{
						wardrobe[color].Add(clothes, 0);
					}

					wardrobe[color][clothes]++;
				}
			}

			string[] neededClothes = Console.ReadLine()
				.Split()
				.ToArray();

			string searchColor = neededClothes[0];
			string searchClothes = neededClothes[1];

			foreach (var clothesColor in wardrobe)
			{
				Console.WriteLine($"{clothesColor.Key} clothes:");

				foreach (var valuePair in clothesColor.Value)
				{
					Console.Write($"* {valuePair.Key} - {valuePair.Value}");

					if (searchColor == clothesColor.Key && searchClothes == valuePair.Key)
					{
						Console.WriteLine(" (found!)");
					}
					else
					{
						Console.WriteLine();
					}
				}
			}
		}
	}
}
