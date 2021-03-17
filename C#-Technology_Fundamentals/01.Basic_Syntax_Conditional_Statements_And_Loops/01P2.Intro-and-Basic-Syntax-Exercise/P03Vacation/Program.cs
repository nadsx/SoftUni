using System;

namespace P03Vacation
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfPeople = int.Parse(Console.ReadLine());
			string groupType = Console.ReadLine();
			string day = Console.ReadLine();

			double price = 0;

			switch (groupType)
			{
				case "Students":
					if(day == "Friday")
					{
						price = 8.45;
					}
					else if(day == "Saturday")
					{
						price = 9.80;
					}
					else if(day == "Sunday")
					{
						price = 10.46;
					}
					break;
				case "Business":
					if (day == "Friday")
					{
						price = 10.90;
					}
					else if (day == "Saturday")
					{
						price = 15.60;
					}
					else if (day == "Sunday")
					{
						price = 16;
					}
					break;
				case "Regular":
					if (day == "Friday")
					{
						price = 15;
					}
					else if (day == "Saturday")
					{
						price = 20;
					}
					else if (day == "Sunday")
					{
						price = 22.50;
					}
					break;
			}

			double totalPrice = 0;

			if(numberOfPeople >= 30 && groupType == "Students")
			{
				totalPrice = (price * numberOfPeople) * 0.85;
			}
			else if(numberOfPeople >= 100 && groupType == "Business")
			{
				totalPrice = (numberOfPeople - 10) * price;
			}
			else if(numberOfPeople >= 10 && numberOfPeople <= 20 && groupType == "Regular")
			{
				totalPrice = (price * numberOfPeople) * 0.95;
			}
			else
			{
				totalPrice = numberOfPeople * price;
			}

			Console.WriteLine($"Total price: {totalPrice:f2}");
		}
	}
}
