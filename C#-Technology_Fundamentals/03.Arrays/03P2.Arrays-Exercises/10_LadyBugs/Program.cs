using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_LadyBugs
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] fieldSize = new int[int.Parse(Console.ReadLine())]; 
			int[] ladyBugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			List<string> commands = Console.ReadLine().Split(' ').ToList();

			for (int i = 0; i < ladyBugsIndexes.Length; i++)
			{
				if (ladyBugsIndexes[i] >= 0 && ladyBugsIndexes[i] < fieldSize.Length)
				{
					fieldSize[ladyBugsIndexes[i]] = 1;
				}
			}

			while (commands[0] != "end")
			{
				int startIndex = int.Parse(commands[0]);
				int flyLength = int.Parse(commands[2]);
				int endIndex = 0;

				if (startIndex >= 0 && startIndex <= fieldSize.Length - 1
					&& fieldSize[startIndex] == 1) 
				{
					fieldSize[startIndex] = 0;

					if (commands[1] == "right")
					{
						endIndex = startIndex + flyLength;

						while (endIndex < fieldSize.Length) 
						{
							if (fieldSize[endIndex] == 0)
							{
								fieldSize[endIndex] = 1;
								break;
							}

							endIndex += flyLength;
						}
					}
					else if (commands[1] == "left")
					{
						endIndex = startIndex - flyLength;

						while (endIndex >= 0)
						{
							if (fieldSize[endIndex] == 0)
							{
								fieldSize[endIndex] = 1;
								break;
							}

							endIndex -= flyLength;
						}
					}
				}

				commands = Console.ReadLine().Split(' ').ToList();
			}

			Console.WriteLine(string.Join(" ", fieldSize));
		}
	}		
}
