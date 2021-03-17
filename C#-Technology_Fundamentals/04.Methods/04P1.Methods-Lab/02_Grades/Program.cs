using System;

namespace _02_Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());

			PrintGrade(grade);
		}

		private static void PrintGrade(double grade)
		{
			var gradeInWords = "";

			if (2.00 <= grade && grade <= 2.99)
			{
				gradeInWords = "Fail";
			}
			else if (3.00 <= grade && grade <= 3.49)
			{
				gradeInWords = "Poor";
			}
			else if (3.50 <= grade && grade <= 4.49)
			{
				gradeInWords = "Good";
			}
			else if (4.50 <= grade && grade <= 5.49)
			{
				gradeInWords = "Very good";
			}
			else if (5.50 <= grade && grade <= 6.00)
			{
				gradeInWords = "Excellent";
			}

			Console.WriteLine(gradeInWords);
		}
	}
}
