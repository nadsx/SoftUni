using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P05Messages
{
	class Program
	{
		static void Main(string[] args)
		{
			int countCharacters = int.Parse(Console.ReadLine());

			int[] array = new int[25];

			string result = string.Empty;

			for (int i = 0; i < countCharacters; i++)
			{
				int textMessage = int.Parse(Console.ReadLine());

				if(textMessage == 0)
				{
					result += " ";
				}
				else
				{
					int length = textMessage.ToString().Length;
					int mainDigit = textMessage % 10;
					int startIndex = (mainDigit - 2) * 3;

					if(mainDigit == 8 || mainDigit == 9)
					{
						startIndex++;
					}

					int letterIndex = startIndex + length - 1;
					result += (char)(97 + letterIndex);
				}
			}

			Console.WriteLine(result);

		}
	}
}
