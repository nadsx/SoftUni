using System;
using System.Linq;

namespace P06ReversedChars
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] reversedChars = new string[3];

			for (int i = 0; i < 3; i++)
			{
				string characters = Console.ReadLine();

				reversedChars[i] = characters;
			}

			reversedChars = reversedChars.Reverse().ToArray();

			Console.WriteLine(string.Join(" ", reversedChars));		
		}
	}
}
