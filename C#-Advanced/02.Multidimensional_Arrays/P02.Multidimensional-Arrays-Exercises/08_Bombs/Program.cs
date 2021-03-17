using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Bombs
{
	class Program
	{
		static void Main(string[] args)
		{
			int matrixSize = int.Parse(Console.ReadLine());
			int[][] matrix = new int[matrixSize][];

			for (int row = 0; row < matrixSize; row++)
			{
				matrix[row] = Console.ReadLine()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
			}

			string[] bombIndexes = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < bombIndexes.Length; i++)
			{
				int bombRow = int.Parse(bombIndexes[i].Split(",")[0]);
				int bombCol = int.Parse(bombIndexes[i].Split(",")[1]);
				int bombDamage = matrix[bombRow][bombCol];

				if (bombDamage > 0)
				{
					for (int row = bombRow - 1; row <= bombRow + 1; row++)
					{
						for (int col = bombCol - 1; col <= bombCol + 1; col++)
						{
							if (IsInside(matrix, row, col))
							{
								if (matrix[row][col] > 0)
								{
									matrix[row][col] -= bombDamage;
								}
							}
						}
					}
				}
			}

			List<int> aliveCells = new List<int>();

			foreach (int[] numbers in matrix)
			{
				foreach (int number in numbers.Where(x => x > 0))
				{
					aliveCells.Add(number);
				}
			}

			Console.WriteLine($"Alive cells: {aliveCells.Count}");
			Console.WriteLine($"Sum: {aliveCells.Sum()}");

			foreach (int[] numbers in matrix)
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}

		private static bool IsInside(int[][] matrix, int bombRow, int bombCol)
		{
			return (bombRow >= 0 && bombRow < matrix.Length) && (bombCol >= 0 && bombCol < matrix[bombRow].Length);
		}
	}
}
