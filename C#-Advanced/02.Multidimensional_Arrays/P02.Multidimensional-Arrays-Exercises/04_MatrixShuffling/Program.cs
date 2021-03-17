using System;
using System.Linq;

namespace _04_MatrixShuffling
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] matrixSize = Console.ReadLine()
			  .Split()
			  .Select(int.Parse)
			  .ToArray();
			int rows = matrixSize[0];
			int cols = matrixSize[1];

			string[,] matrix = new string[rows, cols];
			GetMatrix(matrix);

			while (true)
			{
				string[] commandParts = Console.ReadLine().Split().ToArray();

				if (commandParts[0] == "END")
				{
					break;
				}

				if (commandParts[0] == "swap" && commandParts.Length == 5)
				{
					int firstRow = int.Parse(commandParts[1]);
					int firstCol = int.Parse(commandParts[2]);
					int secondRow = int.Parse(commandParts[3]);
					int secondCol = int.Parse(commandParts[4]);

					bool firstIsValid = IsInside(firstRow, firstCol, matrix);
					bool secondIsValid = IsInside(secondRow, secondCol, matrix);

					if (firstIsValid && secondIsValid)
					{
						string tempNumber = matrix[firstRow, firstCol];
						matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
						matrix[secondRow, secondCol] = tempNumber;

						PrintMatrix(matrix);
					}
					else
					{
						Console.WriteLine("Invalid input!");
					}
				}
				else
				{
					Console.WriteLine("Invalid input!");
				}
			}
		}

		private static void PrintMatrix(string[,] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					Console.Write(matrix[row, col] + " ");
				}

				Console.WriteLine();
			}
		}

		private static bool IsInside(int row, int col, string[,] matrix)
		{
			return (row >= 0 && row < matrix.GetLength(0)) &&
			(col >= 0 && col < matrix.GetLength(1));
		}

		private static void GetMatrix(string[,] matrix)
		{
			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				string[] currentRow = Console.ReadLine().Split().ToArray();

				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = currentRow[col];
				}
			}
		}
	}
}
	

