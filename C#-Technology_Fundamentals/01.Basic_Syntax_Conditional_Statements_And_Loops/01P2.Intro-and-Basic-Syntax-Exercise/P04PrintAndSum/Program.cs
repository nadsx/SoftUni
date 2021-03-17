using System;

namespace P04PrintAndSum
{
	class Program
	{
		static void Main(string[] args)
		{
			int startDigit = int.Parse(Console.ReadLine());
			int endDigit = int.Parse(Console.ReadLine());

			int sum = 0;

			for (int i = startDigit; i <= endDigit; i++)
			{
				sum += i;
				Console.Write(i + " ");
			}
			Console.WriteLine();

			Console.WriteLine($"Sum: {sum}");
		}
	}
}
