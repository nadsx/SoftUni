using System;
using System.Linq;

namespace _05_SnakeMoves
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] matrixSize = Console.ReadLine()
			 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
			 .Select(int.Parse)
			 .ToArray();

			int rows = matrixSize[0];
			int cols = matrixSize[1];

			if (matrixSize.Length == 0)
			{
				return;
			}

			var matrix = new char[rows][];
			var text = Console.ReadLine().ToCharArray();

			int counter = 0;

			for (int row = 0; row < matrix.Length; row++)
			{
				matrix[row] = new char[matrixSize[1]];

				for (int col = 0; col < matrix[row].Length; col++)
				{
					matrix[row][col] = text[counter % text.Length];
					counter++;
				}
			}

			foreach (var row in matrix)
			{
				Console.WriteLine(string.Join("", row));
			}
		}
	}
}
