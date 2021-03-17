using System;

namespace P06BalancedBrackets
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			string lastBracket = string.Empty;
			string print = "BALANCED";

			for (int i = 0; i < n; i++)
			{
				string currentRow = Console.ReadLine();
			
	            if (currentRow == "(")
				{
					if (lastBracket == "(") 
					{
						print = "UNBALANCED";
						break;
					}

					lastBracket = "(";
				}
				else if (currentRow == ")")
				{
					if (lastBracket != "(") // lastBracket moje da e bil i "" ili ")"
					{
						print = "UNBALANCED";
						break;
					}

					lastBracket = ")";
				}

			}

			if (lastBracket == "(") 
			{
				print = "UNBALANCED";
			}

			Console.WriteLine(print);
		}
	}
}
