using System;

namespace P05SpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				int sum = i % 10 + i / 10;

				bool isSpecial = sum == 5 || sum == 7 || sum == 11;

				Console.WriteLine($"{i} -> {isSpecial}");
			}
			
		}
	}
}
