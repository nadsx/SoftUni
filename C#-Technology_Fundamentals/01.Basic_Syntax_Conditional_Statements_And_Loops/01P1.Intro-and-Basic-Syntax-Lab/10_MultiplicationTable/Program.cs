using System;

namespace _10_MultiplicationTable
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int product = 0;

			for (int i = 1; i <= 10; i++)
			{
				product = n * i;
				Console.WriteLine($"{n} X {i} = {product}");
			}

		}
	}
}
