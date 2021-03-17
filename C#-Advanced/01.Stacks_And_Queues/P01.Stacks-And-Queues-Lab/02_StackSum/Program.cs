using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_StackSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Stack<int> numbersStack = new Stack<int>(numbers);

			string input = Console.ReadLine();

			while(input.ToLower() != "end")
			{
				var commandTokens = input.Split().ToArray();
				string command = commandTokens[0].ToLower();

				switch (command)
				{
					case "add":
						int firstNum = int.Parse(commandTokens[1]);
						int secondNum = int.Parse(commandTokens[2]);
						numbersStack.Push(firstNum);
						numbersStack.Push(secondNum);

						break;
					case "remove":
						int countOfNumbersToRemove = int.Parse(commandTokens[1]);

						if(countOfNumbersToRemove <= numbersStack.Count)
						{
							for (int i = 0; i < countOfNumbersToRemove; i++)
							{
								numbersStack.Pop();
							}
						}

						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"Sum: {numbersStack.Sum()}");
		}
	}
}
