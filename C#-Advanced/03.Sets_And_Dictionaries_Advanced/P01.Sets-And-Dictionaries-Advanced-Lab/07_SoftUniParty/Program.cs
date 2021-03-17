using System;
using System.Collections.Generic;

namespace _07_SoftUniParty
{
	class Program
	{
		static void Main(string[] args)
		{
			var vipGuests = new HashSet<string>();
			var regularGuests = new HashSet<string>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "PARTY")
				{
					break;
				}

				if (char.IsDigit(input[0]))
				{
					vipGuests.Add(input);
				}
				else
				{
					regularGuests.Add(input);
				}
			}

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "END")
				{
					break;
				}

				if (char.IsDigit(input[0]))
				{
					vipGuests.Remove(input);
				}
				else
				{
					regularGuests.Remove(input);
				}
			}

			Console.WriteLine($"{vipGuests.Count + regularGuests.Count}");

			foreach (var guest in vipGuests)
			{
				Console.WriteLine(guest);
			}

			foreach (var guest in regularGuests)
			{
				Console.WriteLine(guest);
			}
		}
	}
}
