using System;
using System.Linq;

namespace _06_JaggedArrayModification
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());
			int[][] jaggedArray = new int[rows][];

			for (int row = 0; row < rows; row++)
			{
				int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
				jaggedArray[row] = new int[currentRow.Length];

				for (int col = 0; col < currentRow.Length; col++)
				{
					jaggedArray[row][col] = currentRow[col];
				}
			}

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "END")
				{
					break;
				}

				string[] commandParts = input.Split().ToArray();
				string command = commandParts[0];
				int commandRow = int.Parse(commandParts[1]);
				int commandCol = int.Parse(commandParts[2]);
				int value = int.Parse(commandParts[3]);

				if ((commandRow < 0 || commandRow >= jaggedArray.Length) ||
					(commandCol < 0 || commandCol >= jaggedArray[commandRow].Length))
				{
					Console.WriteLine("Invalid coordinates");
					continue;
				}

				if (command == "Add")
				{
					jaggedArray[commandRow][commandCol] += value;
				}
				else if (command == "Subtract")
				{
					jaggedArray[commandRow][commandCol] -= value;
				}
			}

			foreach (var row in jaggedArray)
			{
				Console.WriteLine(string.Join(" ", row));
			}
		}
	}
}
