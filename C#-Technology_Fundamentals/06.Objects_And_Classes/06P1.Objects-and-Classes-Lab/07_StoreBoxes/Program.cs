using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StoreBoxes
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputLine = Console.ReadLine();

			List<Box> boxes = new List<Box>();

			while (inputLine != "end")
			{
				string[] tokens = inputLine.Split();
				string serialNumber = tokens[0];
				string itemName = tokens[1];
				int itemQuantity = int.Parse(tokens[2]);
				double itemPrice = double.Parse(tokens[3]);

				var item = new Item()
				{
					Name = itemName,
					Price = itemPrice
				};

				var box = new Box()
				{
					SerialNumber = serialNumber,
					BoxItem = item,
					Quantity = itemQuantity,
					PricePerBox = item.Price * itemQuantity
				};

				boxes.Add(box);

				inputLine = Console.ReadLine();
			}

			foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
			{
				Console.WriteLine(box.SerialNumber);
				Console.WriteLine($"-- {box.BoxItem.Name} - ${box.BoxItem.Price:f2}: {box.Quantity}");
				Console.WriteLine($"-- ${box.PricePerBox:f2}");
			}
		}
		class Item
		{
			public string Name { get; set; }
			public double Price { get; set; }
		}
		class Box
		{
			public string SerialNumber { get; set; }
			public Item BoxItem { get; set; }
			public int Quantity { get; set; }
			public double PricePerBox { get; set; }
		}
	}
}
