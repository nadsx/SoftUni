using System;

namespace _04_SymbolInMatrix
{
	class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());

			char[,] matrix = new char[size, size];

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				string input = Console.ReadLine();

				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					matrix[row, col] = input[col];
				}
			}

			char symbol = char.Parse(Console.ReadLine());

			for (int row = 0; row < matrix.GetLength(0); row++)
			{
				for (int col = 0; col < matrix.GetLength(1); col++)
				{
					char currentSymbol = matrix[row, col];

					if (currentSymbol == symbol)
					{
						int rowIndex = row;
						int colIndex = col;

						Console.WriteLine($"({rowIndex}, {colIndex})");
						return;
					}
				}
			}

			Console.WriteLine($"{symbol} does not occur in the matrix");
		}
	}
}
