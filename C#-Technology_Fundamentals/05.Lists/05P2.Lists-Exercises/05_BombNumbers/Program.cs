using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
			int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int bombNumber = operations[0];
			int range = operations[1];

			DetonateBombNumber(numbersList, bombNumber, range);

			Console.WriteLine(numbersList.Sum());
		}

		private static void DetonateBombNumber(List<int> numbersList, int bombNumber, int range)
		{
			while (numbersList.Contains(bombNumber))
			{
				int currentBombIndex = numbersList.IndexOf(bombNumber);

				int startIndex = currentBombIndex - range < 0 ?
					0 : currentBombIndex - range;

				int endIndex = currentBombIndex + range >= numbersList.Count ?
					numbersList.Count - 1 : currentBombIndex + range;

				int numberOfElementsToRemove = endIndex - startIndex;

				for (int i = 0; i <= numberOfElementsToRemove; i++)
				{
					numbersList.RemoveAt(startIndex);
				}
			}
		}
	}
}
