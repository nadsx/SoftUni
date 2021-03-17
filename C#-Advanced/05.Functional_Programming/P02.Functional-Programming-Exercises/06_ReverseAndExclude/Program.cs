using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ReverseAndExclude
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.Reverse()
				.ToList();

			int n = int.Parse(Console.ReadLine());

			Predicate<int> filter = x => x % n != 0;
			
			Console.WriteLine(string.Join(" ", numbers.FindAll(filter)));
		}
	}
}
