using System;
using System.IO;

namespace _04_CopyBinaryFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string picPath = "copyMe.png";
			string picCopyPath = "copyMe-copy.png";

			using (FileStream streamReader = new FileStream(picPath, FileMode.Open))
			{
				using (FileStream streamWriter = new FileStream(picCopyPath, FileMode.Create))
				{
					while (true)
					{
						byte[] buffer = new byte[4096];
						int size = streamReader.Read(buffer, 0, buffer.Length);

						if (size == 0)
						{
							break;
						}

						streamWriter.Write(buffer, 0, size);
					}

				}
			}
		}
	}
}
