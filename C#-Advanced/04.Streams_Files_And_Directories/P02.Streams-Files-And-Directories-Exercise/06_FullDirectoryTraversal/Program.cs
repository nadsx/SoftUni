using System;
using System.IO;
using System.IO.Compression;

namespace _06_FullDirectoryTraversal
{
	class Program
	{
		static void Main(string[] args)
		{
			string zipFile = @"..\..\..\myNewZip.zip";
			string file = "copyMe.png";

			using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
			{
				archive.CreateEntryFromFile(file, Path.GetFileName(file));
			}
		}
	}
}
