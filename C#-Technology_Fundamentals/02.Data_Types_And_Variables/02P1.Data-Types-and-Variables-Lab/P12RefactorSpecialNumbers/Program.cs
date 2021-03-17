using System;

namespace P12RefactorSpecialNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				int num = i;
				int sum = 0;

				while(num != 0)
				{
					int lastDigit = num % 10;
					num /= 10;
					sum += lastDigit;
				}

				bool isSpecial = sum == 5 || sum == 7 || sum == 11;
				Console.WriteLine($"{i} -> {isSpecial}");
			}
		}
	}
}
