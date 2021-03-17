using System;

namespace P03GamingStore
{
	class Program
	{
		static void Main(string[] args)
		{
			double balance = double.Parse(Console.ReadLine());

			double currentBalance = balance;
			double gamePrice = 0;

			string input = Console.ReadLine();
			 
			while(input != "Game Time")
			{
				string gameName = input;

				switch (gameName)
				{
					case "OutFall 4":
						gamePrice = 39.99;
						break;
					case "CS: OG":
						gamePrice = 15.99;
						break;
					case "Zplinter Zell":
						gamePrice = 19.99;
						break;
					case "Honored 2":
						gamePrice = 59.99;
						break;
					case "RoverWatch":
						gamePrice = 29.99;
						break;
					case "RoverWatch Origins Edition":
						gamePrice = 39.99;
						break;
					default:
						Console.WriteLine("Not Found");
						break;
				}

				if(gamePrice > 0 && currentBalance >= gamePrice)
				{
					Console.WriteLine($"Bought {gameName}");
					currentBalance -= gamePrice;
				}
				else if(currentBalance <= gamePrice)
				{
					Console.WriteLine("Too Expensive");
				}

				if(currentBalance <= 0)
				{
					Console.WriteLine("Out of money");
					return;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Total spent: ${balance - currentBalance:f2}." +
				$"Remaining: ${currentBalance:f2}");
		}
	}
}

