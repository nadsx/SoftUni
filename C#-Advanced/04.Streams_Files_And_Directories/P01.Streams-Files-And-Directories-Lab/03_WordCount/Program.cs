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
			var wordsDict = new Dictionary<string, int>();

			using (var reader = new StreamReader("words.txt"))
			{
				while (true)
				{
					string currentLine = reader.ReadLine();

					if (currentLine == null)
					{
						break;
					}

					string[] words = currentLine.Split().ToArray();

					foreach (var word in words)
					{
						if (!wordsDict.ContainsKey(word))
						{
							wordsDict.Add(word.ToLower(), 0);
						}
					}
				}
			}

			using (var reader = new StreamReader("text.txt"))
			{
				while (true)
				{
					string currentLine = reader.ReadLine();

					if (currentLine == null)
					{
						break;
					}

					string[] words = currentLine
					.Split(new char[] { ' ', ',', '?', ';', '-', '.' }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

					foreach (var word in words)
					{
                        string currentWord = word.ToLower();

                        if (wordsDict.ContainsKey(currentWord))
						{
							wordsDict[currentWord]++;
						}
					}
				}
			}

			using (var writer = new StreamWriter("Output.txt"))
			{
				foreach (var word in wordsDict.OrderByDescending(x => x.Value))
				{
					var currentLine = (word.Key + " - " + word.Value);

					writer.WriteLine(currentLine);
				}
			}
		}
	}
}
