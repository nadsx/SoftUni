using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_PokemonDontGo
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> numbersList = Console.ReadLine().Split().Select(long.Parse).ToList();

			long sum = 0;

			while (numbersList.Count > 0)
			{
				int currentIndex = int.Parse(Console.ReadLine());

				long removedElement = 0;

				if (currentIndex < 0)
				{
					removedElement = numbersList[0];
					numbersList[0] = numbersList[numbersList.Count - 1];
				}
				else if (currentIndex >= numbersList.Count)
				{
					removedElement = numbersList[numbersList.Count - 1];
					numbersList[numbersList.Count - 1] = numbersList[0];
				}
				else
				{
					removedElement = numbersList[currentIndex];
					numbersList.RemoveAt(currentIndex);
				}

				sum += removedElement;

				for (int i = 0; i < numbersList.Count; i++)
				{
					if (numbersList[i] <= removedElement)
					{
						numbersList[i] += removedElement;
					}
					else
					{
						numbersList[i] -= removedElement;
					}
				}
			}

			Console.WriteLine(sum);
		}
	}
}
