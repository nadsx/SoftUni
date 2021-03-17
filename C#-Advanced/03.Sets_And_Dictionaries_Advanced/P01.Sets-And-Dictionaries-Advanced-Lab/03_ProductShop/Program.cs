using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ProductShop
{
	class Program
	{
		static void Main(string[] args)
		{
			var shops = new SortedDictionary<string, Dictionary<string, double>>();

			while (true)
			{
				string[] input = Console.ReadLine()
					.Split(", ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				if(input[0] == "Revision")
				{
					break;
				}

				string shopName = input[0];
				string product = input[1];
				double price = double.Parse(input[2]);

				if (!shops.ContainsKey(shopName))
				{
					shops.Add(shopName, new Dictionary<string, double>());
				}

				shops[shopName].Add(product, price);
			}

			foreach(var shop in shops)
			{
				Console.WriteLine(shop.Key + "->");

				foreach(var valuePair in shop.Value)
				{
					Console.WriteLine($"Product: {valuePair.Key}, Price: {valuePair.Value}");
				}
			}
		}
	}
}
