using System;

namespace _07_KnightGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			char[,] board = new char[rows, rows];

			int[] indexes = new int[]
			{
				 1, 2,
				 1,-2,
				-1, 2,
				-1,-2,
				 2, 1,
				 2,-1,
				-2, 1,
				-2,-1,
			};

			for (int row = 0; row < rows; row++)
			{
				char[] currentRow = Console.ReadLine().ToCharArray();

				for (int col = 0; col < rows; col++)
				{
					board[row, col] = currentRow[col];
				}
			}

			int countOfRemovedKnights = 0;

			while (true)
			{
				int maxCount = 0;
				int knightRow = 0;
				int knightCol = 0;

				for (int row = 0; row < board.GetLength(0); row++)
				{
					for (int col = 0; col < board.GetLength(1); col++)
					{
						int count = 0;

						if (board[row, col] == 'K')
						{
							for (int i = 0; i < indexes.Length; i += 2)
							{      
								if (IsInside(board, row + indexes[i], col + indexes[i + 1]) &&
									board[row + indexes[i], col + indexes[i + 1]] == 'K')
								{
									count++;
								}
							}
						}

						if (count > maxCount)
						{
							maxCount = count;
							knightRow = row;
							knightCol = col;
						}
					}
				}

				if (maxCount == 0)
				{
					break;
				}

				board[knightRow, knightCol] = '0';
				countOfRemovedKnights++; 
			}

			Console.WriteLine(countOfRemovedKnights);
		}

		private static bool IsInside(char[,] board, int row, int col)
		{
			return (row >= 0  && row < board.GetLength(0)) &&
				(col >= 0 && col < board.GetLength(1));
		}
	}
}
