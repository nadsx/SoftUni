using System;
using System.Linq;

namespace _03_TakeSkipRope
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] messageIntoChars = Console.ReadLine().ToArray();

			char[] chars = messageIntoChars
			.Where(c => !char.IsDigit(c))
			.ToArray();

			int[] digits = messageIntoChars
				.Where(d => char.IsDigit(d))
				.Select(d => int.Parse(d.ToString()))
				.ToArray();

			var takeList = digits.Where((digit, index) => index % 2 == 0).ToList(); 
			var skipList = digits.Where((digit, index) => index % 2 == 1).ToList(); 

			int totalSkipCount = 0;
			string finalMessage = string.Empty;

			for (int i = 0; i < takeList.Count; i++)
			{
				int takeCount = takeList[i];
				int skipCount = skipList[i];

				finalMessage += new string(chars 
					 .Skip(totalSkipCount) 
					 .Take(takeCount) 
					 .ToArray());

				totalSkipCount += takeCount + skipCount;
			}

			Console.WriteLine(finalMessage);
		}
	}
}
