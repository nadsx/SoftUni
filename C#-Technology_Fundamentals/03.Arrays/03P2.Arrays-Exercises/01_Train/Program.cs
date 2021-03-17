using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int[] wagons = new int[n];
			int sum = 0;

			for (int i = 0; i < n; i++)
			{
				int people = int.Parse(Console.ReadLine());

				wagons[i] += people;
				sum += people;
			}

			Console.Write(string.Join(" ", wagons));
			Console.WriteLine("\n" + sum);
		}
	}
}

