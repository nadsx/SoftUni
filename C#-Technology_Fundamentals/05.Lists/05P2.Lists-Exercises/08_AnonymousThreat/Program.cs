using System;
using System.Linq;

namespace _08_AnonymousThreat
{
	class Program
	{
		static void Main(string[] args)
		{
			var dataLine = Console.ReadLine().Split();

			var input = Console.ReadLine();

			while (input != "3:1")
			{
				var tokens = input.Split();
				var command = tokens[0];

				switch (command)
				{
					case "merge":
						var startIndex = int.Parse(tokens[1]);
						var endIndex = int.Parse(tokens[2]);

						dataLine = Merge(dataLine, startIndex, endIndex);
						break;
					case "divide":
						var index = int.Parse(tokens[1]);
						var partitions = int.Parse(tokens[2]);

						dataLine = Divide(dataLine, index, partitions);
						break;
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", dataLine));
		}

		private static string[] Divide(string[] dataLine, int index, int partitions)
		{
			string element = dataLine[index];

			int partitionLength = element.Length / partitions; 
			string[] divided = new string[partitions]; 

			for (int i = 0; element.Length > partitionLength; i++)
			{
				divided[i] = element.Substring(0, partitionLength);
				element = element.Substring(partitionLength);
			}

			divided[partitions - 1] += element;

			return dataLine.Take(index)
				.Concat(divided)
				.Concat(dataLine.Skip(index + 1))
				.ToArray();
		}

		private static string[] Merge(string[] dataLine, int startIndex, int endIndex)
		{
			string mergedElements = string.Empty;

			if (startIndex < 0)
			{
				startIndex = 0;
			}

			if (endIndex >= dataLine.Length)
			{
				endIndex = dataLine.Length - 1;
			}

			for (int i = startIndex; i <= endIndex; i++)
			{
				mergedElements += dataLine[i];
			}

			return dataLine.Take(startIndex)
				.Concat(new string[] { mergedElements })
				.Concat(dataLine.Skip(endIndex + 1))
				.ToArray();
		}
	}
}
