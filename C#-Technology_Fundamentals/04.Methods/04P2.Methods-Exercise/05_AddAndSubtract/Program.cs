using System;

namespace _05_AddAndSubtract
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());

			int sumOfTwoNumbers = GetSumOfFirstAndSecondNumber(firstNumber, secondNumber);

			int result = GetSubtractResult(sumOfTwoNumbers, thirdNumber);

			Console.WriteLine(result);
		}

		private static int GetSubtractResult(int sumOfTwoNumbers, int thirdNumber)
		{
			return sumOfTwoNumbers - thirdNumber;
		}

		private static int GetSumOfFirstAndSecondNumber(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}
	}
}
