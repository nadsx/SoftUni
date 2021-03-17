using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ListOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			string input = Console.ReadLine();

			while (input != "End")
			{
				string[] tokens = input.Split();
				string command = tokens[0];

				switch (command)
				{
					case "Add":
						int number = int.Parse(tokens[1]);

						numbers.Add(number);
						break;
					case "Insert":
						number = int.Parse(tokens[1]);
						int index = int.Parse(tokens[2]);

						if (index >= 0 && index < numbers.Count)
						{
							numbers.Insert(index, number);
						}
						else
						{
							Console.WriteLine("Invalid index");
						}
						break;
					case "Remove":
						index = int.Parse(tokens[1]);

						if (index >= 0 && index < numbers.Count)
						{
							numbers.RemoveAt(index);
						}
						else
						{
							Console.WriteLine("Invalid index");
						}
						break;
					case "Shift":
						string direction = tokens[1];
						int count = int.Parse(tokens[2]);

						if (direction == "left")
						{
							for (int i = 0; i < count; i++)
							{
								int firstNumber = numbers[0];

								numbers.Add(firstNumber);
								numbers.RemoveAt(0);
							}
						}
						else if (direction == "right")
						{
							for (int i = 0; i < count; i++)
							{
								numbers.Insert(0, numbers[numbers.Count - 1]);
								numbers.RemoveAt(numbers.Count - 1);
							}
						}
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
