using System;
using System.Linq;

namespace _12_TriFunction
{
	class Program
	{
		static void Main(string[] args)
		{
			int length = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine()
				.Split()
				.ToArray();

			Func<string, int, bool> isLarger =
				(name, charsLength) => name.Sum(x => x) >= charsLength;

			Func<string[], Func<string, int, bool>, string> nameFilter =
				(inputNames, isLargerFilter) => inputNames
				.FirstOrDefault(x => isLargerFilter(x, length));

			string resultName = nameFilter(names, isLarger);

			Console.WriteLine(resultName);
		}
	}
}
