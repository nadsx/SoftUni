using System;
using System.Linq;

namespace _09_KaminoFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			int lengthOfDNA = int.Parse(Console.ReadLine());

			int longestSub = -1; // pri input 0!0!0!
			int longestSubIndex = 0;
			int longestSubSum = 0;
			int[] bestSequence = new int[lengthOfDNA];

			int bestSample = 0;
			int sample = 1; // 1 e, zashtoto sample se uvelichava nakraq na cikula 

			string input = Console.ReadLine();

			while (input != "Clone them!")
			{
				int[] currentSequence = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse).ToArray();

				int subSequence = 0;
				int subIndex = 0;
				int subSum = 0;

				int count = 0;

				for (int i = 0; i < lengthOfDNA; i++)
				{
					if (currentSequence[i] == 1)
					{
						count++;
						subSum++;

						if (count > subSequence)
						{
							subSequence = count;
							subIndex = i - count + 1;
						}
					}
					else
					{
						count = 0;
					}
				}

				if (subSequence > longestSub // ne e (|| bestSequence == null), zashtoto longestSub e -1 subSequence moje da 0 i stava 0 > -1 za da vlezi vutre ..pri input 0!0!0!
				|| (subSequence == longestSub && longestSubIndex > subIndex)
				|| (subSequence == longestSub && longestSubIndex == subIndex && longestSubSum < subSum))
				{
					longestSubIndex = subIndex;
					longestSub = subSequence;
					longestSubSum = subSum;
					bestSequence = currentSequence;
					bestSample = sample;
				}

				sample++;
				input = Console.ReadLine();

			}

			Console.WriteLine($"Best DNA sample {bestSample} with sum: {longestSubSum}.");
			Console.WriteLine($"{string.Join(" ", bestSequence)}");
		}
	}
}
