using System;
using System.Collections.Generic;

namespace _08_BalancedParentheses
{
	class Program
	{
		static void Main(string[] args)
		{
			string sequenceOfParentheses = Console.ReadLine();

			Stack<char> parentheses = new Stack<char>();

			bool balanced = true;

			foreach (var bracket in sequenceOfParentheses)
			{
				if (bracket == '{' || bracket == '[' || bracket == '(')
				{
					parentheses.Push(bracket);
					continue;
				}

				if (parentheses.Count == 0 ||
					bracket == '}' && parentheses.Pop() != '{' ||
					bracket == ']' && parentheses.Pop() != '[' ||
					bracket == ')' && parentheses.Pop() != '(')
				{
					balanced = false;
					break;
				}
			}

			Console.WriteLine(balanced ? "YES" : "NO");
		}
	}
}
