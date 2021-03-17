using System;
using System.IO;

namespace _05_SliceFile
{
	class Program
	{
		static void Main(string[] args)
		{
			int fileCount = int.Parse(Console.ReadLine());

			using (var reader = new FileStream("sliceMe.txt", FileMode.Open))
			{
				double partLength = Math.Ceiling((double)reader.Length / fileCount);

				for (int i = 1; i <= fileCount; i++)
				{
					string currentFileName = $"Part-{i}.txt";

					int currentFileTotalBytes = 0;

					using (var writer = new FileStream($"{currentFileName}", FileMode.Create))
					{
						while (true)
						{
							byte[] buffer = new byte[4096];

							int totalReadBytes = reader.Read(buffer, 0, buffer.Length);

							if (totalReadBytes == 0)
							{
								break;
							}

							currentFileTotalBytes += totalReadBytes;

							writer.Write(buffer, 0, totalReadBytes);

							if (currentFileTotalBytes >= partLength)
							{
								break;
							}
						}
					}
				}
			}
		}
	}
}
