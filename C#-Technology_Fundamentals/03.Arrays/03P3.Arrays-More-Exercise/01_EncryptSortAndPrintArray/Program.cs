using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_EncryptSortAndPrintArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfStrings = int.Parse(Console.ReadLine());

			char[] arrOfVowelLetters =
			{
				'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'
			};

			int[] result = new int[numberOfStrings];

			for (int i = 0; i < numberOfStrings; i++)
			{
				string word = Console.ReadLine();
				char[] separateLetters = word.ToCharArray();

				int sum = 0;

				foreach (var letter in separateLetters)
				{
					if (arrOfVowelLetters.Contains(letter))
					{
						sum += letter * separateLetters.Length;
					}
					else
					{
						sum += letter / separateLetters.Length;
					}
				}

				result[i] = sum;
			}

			result = result.OrderBy(x => x).ToArray();

			foreach (var number in result)
			{
				Console.WriteLine(number);
			}
		}
	}	
}
