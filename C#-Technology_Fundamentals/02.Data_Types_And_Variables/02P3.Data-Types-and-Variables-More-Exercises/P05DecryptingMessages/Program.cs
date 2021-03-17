using System;

namespace P05DecryptingMessages
{
	class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int numberLines = int.Parse(Console.ReadLine());

			string print = "";

			for (int i = 0; i < numberLines; i++)
			{
				char currentChar = char.Parse(Console.ReadLine());

				print += (char)(currentChar + key);
			}
			Console.WriteLine(print);
		}
	}
}
