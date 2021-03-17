using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			var initialList = Console.ReadLine().Split('|').Reverse().ToList();
			var finalList = new List<string>();

			for (var i = 0; i < initialList.Count; i++)
			{
				var currentElements = initialList[i]
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.ToList();

				finalList.AddRange(currentElements);
			}

			Console.WriteLine(string.Join(" ", finalList));
		}
	}
}
