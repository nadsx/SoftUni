using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PeriodicTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var chemicalCompounds = new SortedSet<string>();

			for (int i = 0; i < n; i++)
			{
				string[] compounds = Console.ReadLine()
					.Split()
					.ToArray();

				foreach (var element in compounds)
				{
					chemicalCompounds.Add(element);
				}
			}

			Console.WriteLine(string.Join(" ", chemicalCompounds));
		}
	}
}
