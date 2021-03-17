using System;
using System.IO;

namespace _04_MergeFiles
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var firstReader = new StreamReader("Input1.txt"))
			{
				using (var secondReader = new StreamReader("Input2.txt"))
				{
					using (var writer = new StreamWriter("Output.txt"))
					{
						while (true)
						{
							string firstFileLine = firstReader.ReadLine();
							string secondFileLine = secondReader.ReadLine();

							if (firstFileLine == null && secondFileLine == null)
							{
								break;
							}

							if (firstFileLine != null)
							{
								writer.WriteLine(firstFileLine);
							}

							if (firstFileLine != null)
							{
								writer.WriteLine(secondFileLine);
							}
						}
					}
				}
			}
		}
	}
}
