using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_LongestIncreasingSubsequence_LIS_
{
	class Program
	{
		static void Main(string[] args)
		{
			var sequence = Console.ReadLine()
				.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToArray();

			var longestSequence = FindLongestSubSequence(sequence);

			Console.WriteLine(string.Join(" ", longestSequence));
		}

		private static List<int> FindLongestSubSequence(int[] sequence)
		{
			int[] length = new int[sequence.Length];
			int[] previousLongestEndIndex = new int[sequence.Length];

			int maxLength = 0;
			int lastIndex = -1;

			for (int i = 0; i < sequence.Length; i++)
			{
				length[i] = 1;
				previousLongestEndIndex[i] = -1;

				for (int j = 0; j < i; j++)
				{
					if (sequence[j] < sequence[i] && length[j] >= length[i])
					{
						length[i]++;
						previousLongestEndIndex[i] = j;
					}

					if (length[i] > maxLength)
					{
						maxLength = length[i];
						lastIndex = i;
					}
				}
			}

			var longestSequence = new List<int>();

			for (int i = 0; i < maxLength; i++)
			{
				longestSequence.Add(sequence[lastIndex]);
				lastIndex = previousLongestEndIndex[lastIndex];

			}

			longestSequence.Reverse();
			return longestSequence;	
		}
	}
}
