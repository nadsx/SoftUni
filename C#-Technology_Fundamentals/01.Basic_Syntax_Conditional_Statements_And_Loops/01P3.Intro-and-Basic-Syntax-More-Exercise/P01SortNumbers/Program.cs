using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01SortNumbers
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] numbers = new int[3];

			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			numbers = numbers.OrderByDescending(x => x).ToArray();

			foreach (var num in numbers)
			{
				Console.WriteLine(num);
			}


		}
	}
}
