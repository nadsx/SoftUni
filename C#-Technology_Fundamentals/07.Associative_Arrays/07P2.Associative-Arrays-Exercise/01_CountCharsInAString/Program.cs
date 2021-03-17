using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountCharsInAString
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();

			var countChars = new Dictionary<char, int>();

			foreach (var character in text)
			{
				if (!countChars.ContainsKey(character))
				{
					countChars[character] = 0;
				}

				countChars[character]++;
			}

			foreach (var kvp in countChars)
			{
				Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
			}
		}
	}
}
