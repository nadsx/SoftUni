using System;

namespace _04_PrintingTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			for (int i = 1; i <= number; i++)
			{
				PrintingSignleLine(1, i);
			}

			for (int i = number - 1; i >= 1; i--)
			{
				PrintingSignleLine(1, i);
			}
		}

		private static void PrintingSignleLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}
