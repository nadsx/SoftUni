using System;
using System.Linq;

namespace _03_PrimaryDiagonal
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = 0; i < n; i++)
			{
				int[] row = Console.ReadLine()
					.Split()
					.Select(int.Parse)
					.ToArray();

				sum += row[i];
			}

			Console.WriteLine(sum);
		}
	}
}
