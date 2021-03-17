using System;

namespace P10LowerOrUpper
{
	class Program
	{
		static void Main(string[] args)
		{
			char character = char.Parse(Console.ReadLine());

			if (char.IsUpper(character))
			{
				Console.WriteLine("upper-case");
			}
			else
			{
				Console.WriteLine("lower-case");
			}
		}
	}
}
