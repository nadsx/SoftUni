using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_CountUppercaseWords
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> text = Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Where(w => char.IsUpper(w[0]))
				.ToList();

			foreach (var word in text)
			{
				Console.WriteLine(word);
			}
		}
	}
}
