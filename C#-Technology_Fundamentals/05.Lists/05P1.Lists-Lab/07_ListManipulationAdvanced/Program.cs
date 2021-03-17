using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_ListManipulationAdvanced
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			bool isThereAnyChanges = false;

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split();
				string command = tokens[0];

				switch (command)
				{
					case "Add":
						isThereAnyChanges = true;
						int numberToAdd = int.Parse(tokens[1]);

						numbers.Add(numberToAdd);
						break;
					case "Remove":
						isThereAnyChanges = true;
						int numberToRemove = int.Parse(tokens[1]);

						numbers.Remove(numberToRemove);
						break;
					case "RemoveAt":
						isThereAnyChanges = true;
						int indexToRemove = int.Parse(tokens[1]);

						numbers.RemoveAt(indexToRemove);
						break;
					case "Insert":
						isThereAnyChanges = true;
						int numberToInsert = int.Parse(tokens[1]);
						int indexToInsert = int.Parse(tokens[2]);

						numbers.Insert(indexToInsert, numberToInsert);
						break;
					case "Contains":
						int numberToCheck = int.Parse(tokens[1]);

						Console.WriteLine(numbers.Contains(numberToCheck) ? "Yes" : "No such number");
						break;
					case "PrintEven":
						List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

						Console.WriteLine(string.Join(" ", evenNumbers));
						break;
					case "PrintOdd":
						List<int> oddNumbers = numbers.Where(x => x % 2 == 1).ToList();

						Console.WriteLine(string.Join(" ", oddNumbers));
						break;
					case "GetSum":
						int sumNumbers = numbers.Sum();

						Console.WriteLine(sumNumbers);
						break;
					case "Filter":
						string condition = tokens[1];
						int number = int.Parse(tokens[2]);
						List<int> numbersToCheck = numbers.ToList();

						if (condition == "<")
						{
							numbersToCheck = numbersToCheck.Where(x => x < number).ToList();
						}
						else if (condition == ">")
						{
							numbersToCheck = numbersToCheck.Where(x => x > number).ToList();
						}
						else if (condition == ">=")
						{
							numbersToCheck = numbersToCheck.Where(x => x >= number).ToList();
						}
						else if (condition == "<=")
						{
							numbersToCheck = numbersToCheck.Where(x => x <= number).ToList();
						}

						Console.WriteLine(string.Join(" ", numbersToCheck));
						break;
				}

				input = Console.ReadLine();
			}

			if (isThereAnyChanges)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}
	}
}
