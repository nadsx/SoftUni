using System;

namespace _06_MiddleCharacters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			PrintMiddleChars(input);
		}

		private static void PrintMiddleChars(string input)
		{
			if(input.Length % 2 == 0)
			{
				Console.WriteLine($"{input[input.Length / 2 - 1]}{input[input.Length / 2]}");
			}
			else
			{
				Console.WriteLine($"{input[input.Length / 2]}");
			}
		}
	}
}
