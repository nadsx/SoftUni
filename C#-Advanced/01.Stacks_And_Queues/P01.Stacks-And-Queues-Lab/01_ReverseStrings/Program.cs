using System;
using System.Collections.Generic;

namespace _01_ReverseStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<char> stringReversed = new Stack<char>();

			string input = Console.ReadLine();

			foreach (var symbol in input)
			{
				stringReversed.Push(symbol);
			}

			while (stringReversed.Count > 0)
			{
				Console.Write(stringReversed.Pop());
			}

			Console.WriteLine();
		}
	}
}
