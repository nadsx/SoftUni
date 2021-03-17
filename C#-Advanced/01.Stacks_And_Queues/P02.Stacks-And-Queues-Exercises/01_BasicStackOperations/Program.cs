using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_BasicStackOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			var commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>(numbers);

			//for (int i = 0; i < commands[0]; i++)
			//	stack.Push(numbers[i]);
			
			int countOfNumbersToPopS = commands[1];
			int searchedNumberX = commands[2];

			for (int i = 0; i < countOfNumbersToPopS; i++)
			{
				stack.Pop();
			}

			if (stack.Contains(searchedNumberX))
			{
				Console.WriteLine("true");
			}
			else if(stack.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				Console.WriteLine(stack.Min());
			}
		}
	}
}
