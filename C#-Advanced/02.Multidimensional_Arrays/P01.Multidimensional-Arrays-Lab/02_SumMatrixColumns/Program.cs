using System;
using System.Linq;

namespace _02_SumMatrixColumns
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
			.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();

			int rows = dimensions[0];
			int cols = dimensions[1];

			int[,] matrix = new int[rows, cols];

			for (int row = 0; row < rows; row++)
			{
				int[] currentRow = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

				for (int col = 0; col < cols; col++)
				{
					matrix[row, col] = currentRow[col];
				}
			}

			for (int col = 0; col < cols; col++)
			{
				int sum = 0;

				for (int row = 0; row < rows; row++)
				{
					sum += matrix[row, col];
				}

				Console.WriteLine(sum);
			}
		}
	}
}
