using System;

namespace P04RefactoringPrimeChecker
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			for (int i = 2; i <= number; i++)
			{
				bool isPrime = true;
				for (int j = 2; j <= Math.Sqrt(i); j++)
				{                                       // Math.Sqrt() si spestqva vurtene 
					if (i % j == 0)                     // 5 naprimer shte stane 2.236067
					{
						isPrime = false;
						break;
					}
				}
				Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
			}

		}
	}
}
