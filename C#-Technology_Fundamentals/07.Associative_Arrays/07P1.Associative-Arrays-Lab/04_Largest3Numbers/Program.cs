using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Largest3Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbersList = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.OrderByDescending(x => x)
				.Take(3)
				.ToList();

			foreach(var number in numbersList)
			{
				Console.Write(number + " ");
			}

			Console.WriteLine();
		}
	}
}
