using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddOccurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().ToLower().Split();
			var wordsDict = new Dictionary<string, int>();

			foreach(var word in words)
			{
				if (!wordsDict.ContainsKey(word))
				{
					wordsDict[word] = 0;
				};

				wordsDict[word]++;
			}

			var wordsList = wordsDict
				.Where(w => w.Value % 2 == 1)
				.Select(w => w.Key)
				.ToList();

			Console.WriteLine(string.Join(" ", wordsList));
		}
	}
}
