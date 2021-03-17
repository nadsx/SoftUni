using System;

namespace P07ConcatNames
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstName = Console.ReadLine();
			var lastName = Console.ReadLine();
			var delimiter = Console.ReadLine();

			Console.WriteLine($"{firstName}{delimiter}{lastName}");
		}
	}
}
