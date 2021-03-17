using System;
using System.Linq;

namespace _10_RadioactiveMutantVampireBunnies
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] dimensions = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int rows = dimensions[0];
			int cols = dimensions[1];

			bool[,] bunnies = new bool[rows, cols];

			int playerRow = -1, playerCol = -1;

			for (int row = 0; row < rows; row++)
			{
				string currentRow = Console.ReadLine();

				for (int col = 0; col < cols; col++)
				{
					char currentSymbol = currentRow[col];

					if (currentSymbol == 'P')
					{
						playerRow = row;
						playerCol = col;
					}

					bunnies[row, col] = currentSymbol == 'B';
				}
			}

			string commands = Console.ReadLine();

			bool playerEscaped = false;

			foreach (var command in commands)
			{
				int targetRow = playerRow;
				int targetCol = playerCol;

				switch (command)
				{
					case 'R':
						targetCol++;
						break;
					case 'L':
						targetCol--;
						break;
					case 'D':
						targetRow++;
						break;
					case 'U':
						targetRow--;
						break;
				}

				if (targetCol < 0 || targetCol >= cols ||
					targetRow < 0 || targetRow >= rows)
				{
					playerEscaped = true;
				}

				bool[,] newBunnies = new bool[rows, cols];

				for (int row = 0; row < rows; row++)
				{
					for (int col = 0; col < cols; col++)
					{
						if (!bunnies[row, col] || newBunnies[row, col])
							continue;

						if (row > 0 && !bunnies[row - 1, col])
						{
							bunnies[row - 1, col] = true;
							newBunnies[row - 1, col] = true;
						}

						if (row < rows - 1 && !bunnies[row + 1, col])
						{
							bunnies[row + 1, col] = true;
							newBunnies[row + 1, col] = true;
						}

						if (col > 0 && !bunnies[row, col - 1])
						{
							bunnies[row, col - 1] = true;
							newBunnies[row, col - 1] = true;
						}

						if (col < cols - 1 && !bunnies[row, col + 1])
						{
							bunnies[row, col + 1] = true;
							newBunnies[row, col + 1] = true;
						}
					}
				}

				if (!playerEscaped)
				{
					playerRow = targetRow;
					playerCol = targetCol;
				}

				if (playerEscaped || bunnies[playerRow, playerCol])
				{
					break;
				}
			}

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write(bunnies[row, col] ? 'B' : '.');
				}

				Console.WriteLine();
			}

			Console.WriteLine($"{(playerEscaped ? "won" : "dead")}: {playerRow} {playerCol}");
		}
	}
}
