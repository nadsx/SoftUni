using System;

namespace _03_LongerLine
{
	class Program
	{
		static void Main(string[] args)
		{
			double point1X1 = double.Parse(Console.ReadLine());
			double point1Y1 = double.Parse(Console.ReadLine());
			double point1X2 = double.Parse(Console.ReadLine());
			double point1Y2 = double.Parse(Console.ReadLine());

			double point2X1 = double.Parse(Console.ReadLine());
			double point2Y1 = double.Parse(Console.ReadLine());
			double point2X2 = double.Parse(Console.ReadLine());
			double point2Y2 = double.Parse(Console.ReadLine());

			double firstLine = GetLongerLine(point1X1, point1Y1, point1X2, point1Y2);
			double secondLine = GetLongerLine(point2X1, point2Y1, point2X2, point2Y2);

			if (firstLine >= secondLine)
			{
				ClosestPoint(point1X1, point1Y1, point1X2, point1Y2);
			}
			else
			{
				ClosestPoint(point2X1, point2Y1, point2X2, point2Y2);
			}
		}

		static double GetLongerLine(double x1, double y1, double x2, double y2)
		{
			double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
			return result;
		}

		static void ClosestPoint(double x1, double y1, double x2, double y2)
		{
			double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
			double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

			if (firstPoint <= secondPoint)
			{
				Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
				//starting with the point that is closer to the center of the coordinate system 
			}
			else
			{
				Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
			}
		}
	}
}
