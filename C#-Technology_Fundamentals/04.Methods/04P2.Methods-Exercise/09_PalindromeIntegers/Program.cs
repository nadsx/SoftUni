using System;
using System.Linq;

namespace _09_PalindromeIntegers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "END")
			{
				char[] charArray = input.ToCharArray().Reverse().ToArray();
				string reversedInput = new string(charArray);

				bool isPalindrome = input == reversedInput;

				Console.WriteLine(isPalindrome.ToString().ToLower());

				input = Console.ReadLine();
			}
		}
	}
}
