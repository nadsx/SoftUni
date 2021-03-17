using System;
using System.IO;
using System.Numerics;

namespace P01IntegerOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			int thirdNumber = int.Parse(Console.ReadLine());
			int fourthNumber = int.Parse(Console.ReadLine());

			int result = (firstNumber + secondNumber) / thirdNumber * fourthNumber;

			Console.WriteLine(result);
		}
	}
}
