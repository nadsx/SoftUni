using System;

namespace _07_RepeatString
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());

			string result = GetRepeatedString(text, count);

			Console.WriteLine(result);
		}

		private static string GetRepeatedString(string text, int count)
		{
			string result = "";

			for (int i = 0; i < count; i++)
			{
				result += text;
			}

			return result;
		}
	}
}
