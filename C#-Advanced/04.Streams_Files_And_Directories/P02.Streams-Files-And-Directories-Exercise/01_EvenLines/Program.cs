using System;
using System.IO;
using System.Linq;

namespace _01_EvenLines
{
	class Program
	{
		static void Main(string[] args)
		{
			string textFilePath = "../../../text.txt";

			int counter = 0;

			using (StreamReader streamReader = new StreamReader(textFilePath))
			{
				string currentLine = streamReader.ReadLine();

				while (currentLine != null)
				{
					if (counter % 2 == 0)
					{
						string replaceSymbols = ReplaceSpecialCharacters(currentLine);
						string reversedWords = ReversedWords(replaceSymbols);

						Console.WriteLine(reversedWords);
					}

					currentLine = streamReader.ReadLine();

					counter++;
				}
			}
		}

		private static string ReversedWords(string replaceSymbols)
		{
			return string.Join(" ", replaceSymbols.Split().Reverse());
		}

		private static string ReplaceSpecialCharacters(string currentLine)
		{
			return currentLine.Replace("-", "@")
				.Replace(",", "@")
				.Replace(".", "@")
				.Replace("!", "@")
				.Replace("?", "@");
		}
	}
}
