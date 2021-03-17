using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfWords = int.Parse(Console.ReadLine());
			var words = new Dictionary<string, List<string>>();

			for (int i = 0; i < countOfWords; i++)
			{
				string word = Console.ReadLine();
				string synonym = Console.ReadLine();

				if (!words.ContainsKey(word))
				{
					words[word] = new List<string>();
				}

				words[word].Add(synonym);
			}

			foreach(var kvp in words)
			{
				Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
			}
		}
	}
}
