using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string textPath = "text.txt";
			string wordsPath = "words.txt";

			string[] textLines = File.ReadAllLines(textPath);
			string[] words = File.ReadAllLines(wordsPath);

			var wordsInfo = new Dictionary<string, int>();

			foreach (var word in words)
			{
				string currentWord = word.ToLower();

				if (!wordsInfo.ContainsKey(currentWord))
				{
					wordsInfo.Add(currentWord, 0);
				}
			}

			foreach (var currentLine in textLines)
			{
				string[] currentLineWords = currentLine
					.ToLower()
					.Split(new[] { ' ', '-', ',', '?', '!', '.', '\'', ':', ';' })
					.ToArray();

				foreach (var currentWord in currentLineWords)
				{
					if (wordsInfo.ContainsKey(currentWord))
					{
						wordsInfo[currentWord]++;
					}
				}
			}

			string actualResultPath = "actualResult.txt";
			string expectedResultPath = "expectedResult.txt";

			foreach (var (key, value) in wordsInfo)
			{
				File.AppendAllText(actualResultPath, $"{key} - {value}" +
					$"{Environment.NewLine}");
			}

			foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
			{
				File.AppendAllText(expectedResultPath, $"{key} - {value}" +
					$"{Environment.NewLine}");
			}
		}
	}
}
