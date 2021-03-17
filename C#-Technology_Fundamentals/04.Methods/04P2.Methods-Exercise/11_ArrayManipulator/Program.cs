using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ArrayManipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split();
				string command = tokens[0];

				switch (command)
				{
					case "exchange":
						int index = int.Parse(tokens[1]);

						arrayOfNumbers = ExchangeArrayElements(arrayOfNumbers, index);
						break;
					case "max":
					case "min":
						string maxOrMin = command;
						string evenOrOdd = tokens[1];

						FindMaxOrMinEvenOrOddElement(arrayOfNumbers, maxOrMin, evenOrOdd);
						break;
					case "first":
					case "last":
						string firstOrLast = command;
						int count = int.Parse(tokens[1]);
						evenOrOdd = tokens[2];

						FindFirstOrLastEvenOrOddElements(arrayOfNumbers, firstOrLast, count, evenOrOdd);
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"[{string.Join(", ", arrayOfNumbers)}]"); 
		}

		private static void FindFirstOrLastEvenOrOddElements(int[] arrayOfNumbers, string firstOrLast, int count, string evenOrOdd)
		{
			if (count > arrayOfNumbers.Length)
			{
				Console.WriteLine("Invalid count");
				return;
			}

			int evenOrOddRemainder = evenOrOdd == "even" ? 0 : 1;
			int[] evenOrOddElements = arrayOfNumbers.Where(x => x % 2 == evenOrOddRemainder).ToArray();  

			int[] foundElements; // = null

			if (firstOrLast == "first")
			{
				foundElements = evenOrOddElements.Take(count).ToArray();
			}
			else
			{
				foundElements = evenOrOddElements.Reverse().Take(count).Reverse().ToArray();
			}

			Console.WriteLine($"[{string.Join(", ", foundElements)}]");
		}

		private static void FindMaxOrMinEvenOrOddElement(int[] arrayOfNumbers, string maxOrMin, string evenOrOdd)
		{
			int evenOrOddElementsRemainder = evenOrOdd == "even" ? 0 : 1;
			int[] evenOrOddElements = arrayOfNumbers.Where(x => x % 2 == evenOrOddElementsRemainder).ToArray();

			if (!evenOrOddElements.Any())    
			{
				Console.WriteLine("No matches");
				return;
			}

			int maxOrMinElement = 0;

			if (maxOrMin == "max")
			{
				maxOrMinElement = evenOrOddElements.Max();
			}
			else
			{
				maxOrMinElement = evenOrOddElements.Min();
			}

			int maxOrMinElementIndex = Array.LastIndexOf(arrayOfNumbers, maxOrMinElement);
			//.LastIndexOf() = If there are two or more equal min/max elements, return the index of the rightmost one
			Console.WriteLine(maxOrMinElementIndex);
		}

		private static int[] ExchangeArrayElements(int[] arrayOfNumbers, int index)
		{
			bool isValidIndex = index >= 0 && index < arrayOfNumbers.Length;

			if (!isValidIndex)
			{
				Console.WriteLine("Invalid index");
				return arrayOfNumbers;
			}

			List<int> leftPart = arrayOfNumbers.Take(index + 1).ToList(); 
			List<int> rightPart = arrayOfNumbers.Skip(index + 1).ToList();

			int[] combinedArray = rightPart.Concat(leftPart).ToArray();
			return combinedArray;
		}
	}
}
