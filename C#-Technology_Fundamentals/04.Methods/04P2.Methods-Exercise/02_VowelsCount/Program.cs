using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_VowelsCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine().ToLower();

			Console.WriteLine(GetVowelsCount(text));
		}

		private static int GetVowelsCount(string text)
		{
			int vowelsCount = 0;

			foreach (var letter in text)
			{
				if (letter == 'a' ||
					letter == 'e' ||
					letter == 'u' ||
					letter == 'o' ||
					letter == 'i')
				{
					vowelsCount++;
				}
			}

			return vowelsCount;
		}
	}	
}
