using System;

namespace _11_MathOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			char @operator = char.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());

			int result = GetCalculation(firstNumber, @operator, secondNumber);

			Console.WriteLine(result);
		}

		private static int GetCalculation(int firstNumber, char @operator, int secondNumber)
		{
			int result = 0;

			switch (@operator)
			{
				case '/':
					result = firstNumber / secondNumber;
					break;
				case '*':
					result = firstNumber * secondNumber;
					break;
				case '+':
					result = firstNumber + secondNumber;
					break;
				case '-':
					result = firstNumber - secondNumber;
					break;

			}

			return result;
		}
	}
}
