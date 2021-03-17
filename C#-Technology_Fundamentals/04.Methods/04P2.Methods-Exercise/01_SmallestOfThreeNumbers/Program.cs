using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SmallestOfThreeNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());

			int smallerNumber = GetSmallerNumber(firstNumber, secondNumber);
			int result = GetSmallerNumber(smallerNumber, thirdNumber);

			Console.WriteLine(result);
		}

		private static int GetSmallerNumber(int firstNumber, int secondNumber)
		{
			return firstNumber <= secondNumber ? firstNumber : secondNumber;
		}
	}			
}
	

