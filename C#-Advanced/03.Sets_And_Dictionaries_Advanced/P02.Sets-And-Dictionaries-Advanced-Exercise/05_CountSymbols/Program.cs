using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_CountSymbols
{
	class Program
	{
		static void Main(string[] args)
		{
			var text = Console.ReadLine();
			var charCount = new Dictionary<char, int>();

			for (int i = 0; i < text.Length; i++)
			{
				char currentChar = text[i];

				if (!charCount.ContainsKey(currentChar))
				{
					charCount.Add(currentChar, 0);
				}

				charCount[currentChar]++;
			}

			foreach (var character in charCount.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{character.Key}: {character.Value} time/s");
			}
		}
	}
}
