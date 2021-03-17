using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split();
				string command = tokens[0];

				switch (command)
				{
					case "Delete":
						int elementToRemove = int.Parse(tokens[1]);

						numbers.RemoveAll(x => x == elementToRemove);
						break;
					case "Insert":
						int element = int.Parse(tokens[1]);
						int position = int.Parse(tokens[2]);

						numbers.Insert(position, element);
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", numbers));
		}
	}
}
