using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_PredicateParty
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> listOfGuests = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			while (true)
			{
				string[] input = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string command = input[0];

				if (command == "Party!")
				{
					break;
				}

				string criteria = input[1];
				string condition = input[2];
				Func<string, bool> filter;

				switch (command)
				{
					case "Remove" when criteria == "StartsWith":
						filter = x => !x.StartsWith(condition);
						break;
					case "Remove" when criteria == "EndsWith":
						filter = x => !x.EndsWith(condition);
						break;
					case "Remove":
						filter = x => x.Length != int.Parse(condition);
						break;
					case "Double" when criteria == "StartsWith":
						filter = x => x.StartsWith(condition);
						break;
					case "Double" when criteria == "EndsWith":
						filter = x => x.EndsWith(condition);
						break;
					default:
						filter = x => x.Length == int.Parse(condition);
						break;
				}

				if (command == "Remove")
				{
					listOfGuests = listOfGuests.Where(filter).ToList();
				}
				else
				{
					List<string> tempList = listOfGuests.Where(filter).ToList();

					foreach (var name in tempList)
					{
						int index = listOfGuests.IndexOf(name);
						listOfGuests.Insert(index, name);
					}
				}
			}

			Console.WriteLine(listOfGuests.Any() ?
				$"{string.Join(", ", listOfGuests)} are going to the party!" :
				"Nobody is going to the party!");
		}
	}
}
