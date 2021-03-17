using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_RandomizeWords
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split();

			var random = new Random();

			for (int i = 0; i < words.Length; i++)
			{
				int randomIndex = random.Next(0, words.Length);

				string temp = words[i];
				words[i] = words[randomIndex];
				words[randomIndex] = temp;

			}

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}
