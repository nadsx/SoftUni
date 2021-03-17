using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_PrintEvenNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			Queue<int> evenNumbers = new Queue<int>(numbers.Where(n => n % 2 == 0));

			Console.WriteLine(string.Join(", ", evenNumbers));
		}
	}
}
