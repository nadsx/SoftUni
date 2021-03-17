using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_SimpleTextEditor
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfOperations = int.Parse(Console.ReadLine());
			Stack<string> statesOfTexts = new Stack<string>();

			statesOfTexts.Push(string.Empty);

			for (int i = 0; i < numberOfOperations; i++)
			{
				string[] tokens = Console.ReadLine().Split().ToArray();
				string command = tokens[0];

				switch (command)
				{
					case "1":
						string textToAdd = tokens[1];
						string lastText = statesOfTexts.Peek();
						lastText += textToAdd;
						statesOfTexts.Push(lastText);
						break;
					case "2":
						int count = int.Parse(tokens[1]);
						string textToCut = statesOfTexts.Peek();
						textToCut = textToCut.Substring(0, textToCut.Length - count);
						statesOfTexts.Push(textToCut);
						break;
					case "3":
						int index = int.Parse(tokens[1]);
						Console.WriteLine(statesOfTexts.Peek()[index - 1]);
						break;
					case "4":
						statesOfTexts.Pop();
						break;
				}
			}
		}
	}
}
