using System;
using System.Collections.Generic;

namespace _06_Supermarket
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> supermarket = new Queue<string>();

			string input = Console.ReadLine();

			while(input != "End")
			{
				if(input == "Paid")
				{
					int numberOfCustomers = supermarket.Count;

					for (int i = 0; i < numberOfCustomers; i++)
					{
						Console.WriteLine(supermarket.Dequeue());
					}
				}
				else
				{
					supermarket.Enqueue(input);
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"{supermarket.Count} people remaining.");
		}
	}
}
