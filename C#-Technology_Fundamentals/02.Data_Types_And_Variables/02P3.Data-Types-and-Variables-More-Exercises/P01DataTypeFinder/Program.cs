using System;
using System.Collections.Generic;
using System.Linq;

namespace P01DataTypeFinder
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "END")
			{
				if (int.TryParse(input, out int integer))
				{
					Console.WriteLine($"{integer} is integer type");
				}
				else if (double.TryParse(input, out double floatingPoint))
				{
					Console.WriteLine($"{floatingPoint} is floating point type");
				}
				else if (char.TryParse(input, out char character))
				{
					Console.WriteLine($"{character} is character type");
				}
				else if (bool.TryParse(input, out bool boolean))
				{
					Console.WriteLine($"{boolean} is boolean type");
				}
				else
				{
					Console.WriteLine($"{input} is string type");
				}

				input = Console.ReadLine();
			}

		}
	}
}

