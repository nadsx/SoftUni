using System;

namespace P11RefactorVolumeOfPyramid
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Length: ");
			var length = double.Parse(Console.ReadLine());
			Console.Write("Width: ");
			var width = double.Parse(Console.ReadLine());
			Console.Write("Height: ");
			var height = double.Parse(Console.ReadLine());

			var volumeOfPyramid = (width * length * height) / 3;

			Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");
		}
	}
}
