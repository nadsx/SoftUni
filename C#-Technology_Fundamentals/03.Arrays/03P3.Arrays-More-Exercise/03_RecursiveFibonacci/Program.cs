using System;

namespace _03_RecursiveFibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			int fibonacciNumber = int.Parse(Console.ReadLine());

			if(fibonacciNumber == 1 || fibonacciNumber == 2)
			{
				Console.WriteLine(1);
			}
			else
			{
				int[] array = new int[fibonacciNumber];
				array[0] = 1;
				array[1] = 1;

				for (int i = 2; i < fibonacciNumber; i++)
				{
					array[i] = array[i - 1] + array[i - 2];
				}

				Console.WriteLine(array[fibonacciNumber - 1]);
			}
		}
	}
}
