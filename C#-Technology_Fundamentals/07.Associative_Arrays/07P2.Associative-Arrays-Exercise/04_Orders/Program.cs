using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			var products = new Dictionary<string, double[]>();

			var input = Console.ReadLine();

			while (input != "buy")
			{
				var productInfo = input.Split().ToList();
				var product = productInfo[0];
				var price = double.Parse(productInfo[1]);
				var quantity = int.Parse(productInfo[2]);

				if (!products.ContainsKey(product))
				{
					products[product] = new double[2];
				}

				products[product][0] = price;
				products[product][1] += quantity;

				input = Console.ReadLine();
			}

			foreach (var product in products)
			{
				Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
			}
		}
	}
}
