using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumAndMinimumElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < n; i++)
			{
				int[] commandTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
				int command = commandTokens[0];

				if(command == 1)
				{
					int number = commandTokens[1];
					stack.Push(number);
				}

				if (stack.Count > 0)
				{
					switch (command)
					{
						case 2:
							stack.Pop();
							break;
						case 3:
							Console.WriteLine(stack.Max());
							break;
						case 4:
							Console.WriteLine(stack.Min());
							break;
					}
				}
			}

			Console.WriteLine(string.Join(", ", stack));
		}
	}
}
