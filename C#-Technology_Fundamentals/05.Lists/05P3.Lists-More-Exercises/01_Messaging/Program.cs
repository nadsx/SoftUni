using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace _01_Messaging
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<char> text = Console.ReadLine().ToList();

			int digitsSum = 0;

			for (int i = 0; i < numbers.Count; i++)
			{
				while (numbers[i] > 0)
				{
					digitsSum += numbers[i] % 10;
					numbers[i] /= 10;
				}

				if (digitsSum < text.Count)
				{
					Console.Write(text[digitsSum]);
					text.RemoveAt(digitsSum);
				}
				else
				{
					digitsSum = digitsSum - text.Count;
					Console.Write(text[digitsSum]);
					text.RemoveAt(digitsSum);
				}

				digitsSum = 0;
			}

			Console.WriteLine();
		}
	}
}