using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SimpleCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var values = input.Split(' ').ToArray();

			var calculatorStack = new Stack<string>(values.Reverse());

			while (calculatorStack.Count > 1)
			{
				int firstOperand = int.Parse(calculatorStack.Pop());
				string operatorStr = calculatorStack.Pop();
				int secondOperand = int.Parse(calculatorStack.Pop());

				switch (operatorStr)
				{
					case "+":
						calculatorStack.Push((firstOperand + secondOperand).ToString());
						break;
					case "-":
						calculatorStack.Push((firstOperand - secondOperand).ToString());
						break;
				}
			}

			Console.WriteLine(calculatorStack.Pop());
		}
	}
}
