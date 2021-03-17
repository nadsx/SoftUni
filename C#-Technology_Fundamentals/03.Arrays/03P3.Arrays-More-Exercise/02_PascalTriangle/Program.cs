using System;

namespace _02_PascalTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfRows = int.Parse(Console.ReadLine());

			if (numberOfRows == 1)
			{
				Console.WriteLine(1);
				return;
			}

			Console.WriteLine(1);

			int[] array = { 1, 1 };
			Console.WriteLine(string.Join(" ", array));

			if (numberOfRows == 2)
				return;

			for (int i = array.Length; i < numberOfRows; i++) //
			{
				int[] changingArray = new int[array.Length + 1];

				for (int j = 1; j < changingArray.Length - 1; j++)
				{
					changingArray[0] = 1;
					changingArray[changingArray.Length - 1] = 1;

					changingArray[j] = array[j - 1] + array[j];
				}

				Console.WriteLine(string.Join(" ", changingArray));

				array = changingArray;
			}
		}
	}
}
