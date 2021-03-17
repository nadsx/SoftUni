using System;
using System.Linq;

namespace _07_PredicateForNames
{
	class Program
	{
		static void Main(string[] args)
		{
			int nameLength = int.Parse(Console.ReadLine());

			Console.ReadLine()
				.Split(" ", StringSplitOptions.RemoveEmptyEntries)
				.Where(x => x.Length <= nameLength)
				.ToList()
				.ForEach(Console.WriteLine);
		}
	}
}
