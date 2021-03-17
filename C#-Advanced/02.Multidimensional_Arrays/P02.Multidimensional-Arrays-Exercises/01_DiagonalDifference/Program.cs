using System;
using System.Linq;

namespace _01_DiagonalDifference
{
	class Program
	{
		public static void Main()
		{
			int matrixSize = int.Parse(Console.ReadLine());

			int[][] matrix = new int[matrixSize][];
			int leftDiagonalSum = 0;
			int rightDiagonalSum = 0;

			for (int i = 0; i < matrixSize; i++)
			{
				matrix[i] = Console.ReadLine()
					.Split(" ", StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();

				leftDiagonalSum += matrix[i][i];
				rightDiagonalSum += matrix[i][matrix[i].Length - 1 - i];

			}

			Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
		}
	}
}
